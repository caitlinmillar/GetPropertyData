using Newtonsoft.Json;

namespace GetPropertyData
{

    public class RequestDefinition
    {
       
            public List<string> columnNames { get; set; }
            public List<string> columnValues { get; set; }
        

    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Customer
    {
        [JsonProperty("Customer ID")]
        public string CustomerID { get; set; }

        [JsonProperty("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Last Name")]
        public string LastName { get; set; }

        [JsonProperty("Date of Birth")]
        public string DateofBirth { get; set; }

        [JsonProperty("Email Address")]
        public string EmailAddress { get; set; }

        [JsonProperty("Phone Number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("Property Address")]
        public string PropertyAddress { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string id { get; set; }
        public string _rid { get; set; }
        public string _self { get; set; }
        public string _etag { get; set; }
        public string _attachments { get; set; }
        public int _ts { get; set; }
    }



    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class G
    {
        [JsonProperty(" new build/conversion)?")]
        public string newbuildconversion { get; set; }

        [JsonProperty(" underpinning or strengthening)?")]
        public string underpinningorstrengthening { get; set; }
    }

    public class HaveThereBeenAnyStructuralRepairsE
    {
        public G g { get; set; }
    }

    public class IsThePropertyAwaitingFirstOccupationInItsCurrentFormE
    {
        public G g { get; set; }
    }

    public class InspectionData
    {
        public string UPRN { get; set; }

        [JsonProperty("Is non traditional construction type")]
        public string Isnontraditionalconstructiontype { get; set; }

        [JsonProperty("Cladding recorded")]
        public string Claddingrecorded { get; set; }
        public string Lender { get; set; }

        [JsonProperty("Property Address")]
        public string PropertyAddress { get; set; }

        [JsonProperty("Assesment Date")]
        public string AssesmentDate { get; set; }

        [JsonProperty("Job Reference")]
        public string JobReference { get; set; }
        public string Company { get; set; }

        [JsonProperty("Overall Condition")]
        public string OverallCondition { get; set; }

        [JsonProperty("Mortgage Purpose")]
        public string MortgagePurpose { get; set; }

        [JsonProperty("Is the property awaiting first occupation in its current form (e")]
        public IsThePropertyAwaitingFirstOccupationInItsCurrentFormE Isthepropertyawaitingfirstoccupationinitscurrentforme { get; set; }

        [JsonProperty("Occupancy Status")]
        public string OccupancyStatus { get; set; }

        [JsonProperty("Record tenancy details")]
        public string Recordtenancydetails { get; set; }

        [JsonProperty("Is the property in an area which falls under selective licensing?")]
        public string Isthepropertyinanareawhichfallsunderselectivelicensing { get; set; }
        public string HMO { get; set; }

        [JsonProperty("Property Location")]
        public string PropertyLocation { get; set; }

        [JsonProperty("Name of Builder/Developer")]
        public string NameofBuilderDeveloper { get; set; }

        [JsonProperty("Have there been any structural repairs (e")]
        public HaveThereBeenAnyStructuralRepairsE Havetherebeenanystructuralrepairse { get; set; }

        [JsonProperty("Are there any proposed works/improvements?")]
        public string Arethereanyproposedworksimprovements { get; set; }

        [JsonProperty("Have any works been carried out which might be covered by a warranty or guarantee?")]
        public string Haveanyworksbeencarriedoutwhichmightbecoveredbyawarrantyorguarantee { get; set; }

        [JsonProperty("Any signs of significant alterations/extensions to the property?")]
        public string Anysignsofsignificantalterationsextensionstotheproperty { get; set; }

        [JsonProperty("Alterations include")]
        public string Alterationsinclude { get; set; }

        [JsonProperty("Do any of these works appear to have been carried out within the last 10 years?")]
        public string Doanyoftheseworksappeartohavebeencarriedoutwithinthelast10years { get; set; }

        [JsonProperty("Are the alteration/extension in a state that would suggest that no appropriate approvals have been obtained or complied with?")]
        public string Arethealterationextensioninastatethatwouldsuggestthatnoappropriateapprovalshavebeenobtainedorcompliedwith { get; set; }

        [JsonProperty("Please select the main roof construction")]
        public string Pleaseselectthemainroofconstruction { get; set; }

        [JsonProperty("Are there solar panels at the property?")]
        public string Aretheresolarpanelsattheproperty { get; set; }

        [JsonProperty("Identify property construction type if known")]
        public string Identifypropertyconstructiontypeifknown { get; set; }

        [JsonProperty("Has the roof covering been treated with sealant or sprayfoam, either internally or externally?")]
        public string Hastheroofcoveringbeentreatedwithsealantorsprayfoameitherinternallyorexternally { get; set; }

        [JsonProperty("Pitched Roof Condition")]
        public string PitchedRoofCondition { get; set; }

        [JsonProperty("ExtWalls type")]
        public string ExtWallstype { get; set; }

        [JsonProperty("ExtWalls Condition")]
        public string ExtWallsCondition { get; set; }

        [JsonProperty("Windows Condition")]
        public string WindowsCondition { get; set; }

        [JsonProperty("Windows (Glazing)")]
        public string WindowsGlazing { get; set; }

        [JsonProperty("Windows (Framing)")]
        public string WindowsFraming { get; set; }

        [JsonProperty("Site & Boundaries Boundary")]
        public string SiteBoundariesBoundary { get; set; }

        [JsonProperty("Roof Space Inspection")]
        public string RoofSpaceInspection { get; set; }

        [JsonProperty("Roof Space State Restriction")]
        public string RoofSpaceStateRestriction { get; set; }

        [JsonProperty("Roof Space Construction")]
        public string RoofSpaceConstruction { get; set; }

        [JsonProperty("Roof Space Condition")]
        public string RoofSpaceCondition { get; set; }

        [JsonProperty("Roof Space Limitations")]
        public string RoofSpaceLimitations { get; set; }

        [JsonProperty("Ceilings Condition")]
        public string CeilingsCondition { get; set; }

        [JsonProperty("Floors Condition")]
        public string FloorsCondition { get; set; }

        [JsonProperty("Internal Walls and Partitions Condition")]
        public string InternalWallsandPartitionsCondition { get; set; }

        [JsonProperty("Timber and Damp Having carried out relevant damp checks, is there any evidence of significant damp?")]
        public string TimberandDampHavingcarriedoutrelevantdampchecksisthereanyevidenceofsignificantdamp { get; set; }

        [JsonProperty("Timber and Damp Any evidence of significant timber defects?")]
        public string TimberandDampAnyevidenceofsignificanttimberdefects { get; set; }

        [JsonProperty("Chimney Breasts Altered or Removed?")]
        public string ChimneyBreastsAlteredorRemoved { get; set; }

        [JsonProperty("Chimney Breasts Condition")]
        public string ChimneyBreastsCondition { get; set; }

        [JsonProperty("Chimney Stacks, Flues & Flashings Condition")]
        public string ChimneyStacksFluesFlashingsCondition { get; set; }

        [JsonProperty("F&F Kitchens")]
        public string FFKitchens { get; set; }

        [JsonProperty("F&F Bathrooms")]
        public string FFBathrooms { get; set; }

        [JsonProperty("F&F Internal Decorations")]
        public string FFInternalDecorations { get; set; }

        [JsonProperty("Electricity Supply")]
        public string ElectricitySupply { get; set; }

        [JsonProperty("Gas Supply")]
        public string GasSupply { get; set; }

        [JsonProperty("Water Supply")]
        public string WaterSupply { get; set; }

        [JsonProperty("Drainage System")]
        public string DrainageSystem { get; set; }

        [JsonProperty("Drainage Private System")]
        public string DrainagePrivateSystem { get; set; }

        [JsonProperty("Does the drainage system have a run off or is it located on neighbouring land?")]
        public string Doesthedrainagesystemhavearunofforisitlocatedonneighbouringland { get; set; }

        [JsonProperty("Central Heating Extent")]
        public string CentralHeatingExtent { get; set; }

        [JsonProperty("Central Heating Type")]
        public string CentralHeatingType { get; set; }

        [JsonProperty("Central Heating Outlet")]
        public string CentralHeatingOutlet { get; set; }

        [JsonProperty("Hot Water Supply")]
        public string HotWaterSupply { get; set; }

        [JsonProperty("Outbuildings Condition")]
        public string OutbuildingsCondition { get; set; }

        [JsonProperty("Outbuildings Inspection")]
        public string OutbuildingsInspection { get; set; }

        [JsonProperty("Outbuildings Wall Construction")]
        public string OutbuildingsWallConstruction { get; set; }

        [JsonProperty("Outbuildings Roof Construction")]
        public string OutbuildingsRoofConstruction { get; set; }

        [JsonProperty("Are Works Required to make the property fit for letting?")]
        public string AreWorksRequiredtomakethepropertyfitforletting { get; set; }

        [JsonProperty("What is the property's EPC rating")]
        public string WhatisthepropertysEPCrating { get; set; }

        [JsonProperty("Is there a potential for more than 5 sharers?")]
        public string Isthereapotentialformorethan5sharers { get; set; }

        [JsonProperty("Letting Suitability")]
        public string LettingSuitability { get; set; }

        [JsonProperty("Property Type")]
        public string PropertyType { get; set; }

        [JsonProperty("Property type suplimental")]
        public string Propertytypesuplimental { get; set; }

        [JsonProperty("Property Style")]
        public string PropertyStyle { get; set; }

        [JsonProperty("Build Format")]
        public string BuildFormat { get; set; }

        [JsonProperty("Was the property built before 1850?")]
        public string Wasthepropertybuiltbefore1850 { get; set; }

        [JsonProperty("Does the property appear to be of public sector origins?")]
        public string Doesthepropertyappeartobeofpublicsectororigins { get; set; }

        [JsonProperty("Is the property a flat?")]
        public string Isthepropertyaflat { get; set; }

        [JsonProperty("Floors in block")]
        public string Floorsinblock { get; set; }

        [JsonProperty("Flats on same floor")]
        public string Flatsonsamefloor { get; set; }
        public string Age { get; set; }

        [JsonProperty("Main accommodation assumed to be on which floor")]
        public string Mainaccommodationassumedtobeonwhichfloor { get; set; }

        [JsonProperty("Assumed number of flats in block")]
        public string Assumednumberofflatsinblock { get; set; }

        [JsonProperty("Lift to the entrance of the flat?")]
        public string Lifttotheentranceoftheflat { get; set; }

        [JsonProperty("Is the Property above or adjacent to commercial premises?")]
        public string IsthePropertyaboveoradjacenttocommercialpremises { get; set; }

        [JsonProperty("Area predominantly")]
        public string Areapredominantly { get; set; }

        [JsonProperty("Nature of housing")]
        public string Natureofhousing { get; set; }

        [JsonProperty("Additional property location considerations and affect")]
        public string Additionalpropertylocationconsiderationsandaffect { get; set; }

        [JsonProperty("In a Conservation Area?")]
        public string InaConservationArea { get; set; }

        [JsonProperty("Are there any Adverse Locational Factors?")]
        public string ArethereanyAdverseLocationalFactors { get; set; }

        [JsonProperty("Status of Roads / Pavements abutting the property")]
        public string StatusofRoadsPavementsabuttingtheproperty { get; set; }

        [JsonProperty("Is there pedestrian access only?")]
        public string Istherepedestrianaccessonly { get; set; }

        [JsonProperty("Location Type")]
        public string LocationType { get; set; }

        [JsonProperty("Do you have concerns that there may be Metal Composite panels (ACM/MCM) or HPL present?")]
        public string DoyouhaveconcernsthattheremaybeMetalCompositepanelsACMMCMorHPLpresent { get; set; }

        [JsonProperty("Rationale for not requiring an EWS1 (site notes only)")]
        public string RationalefornotrequiringanEWS1sitenotesonly { get; set; }

        [JsonProperty("Does the block appear to be poorly maintained?")]
        public string Doestheblockappeartobepoorlymaintained { get; set; }
        public string Tenure { get; set; }

        [JsonProperty("Source of Tenure Information")]
        public string SourceofTenureInformation { get; set; }

        [JsonProperty("Unexpired Term of lease")]
        public string UnexpiredTermoflease { get; set; }

        [JsonProperty("Is the Ground Rent likely to adversely affect value or saleability?")]
        public string IstheGroundRentlikelytoadverselyaffectvalueorsaleability { get; set; }

        [JsonProperty("Is the lease considered to be sufficiently adverse to decline this property?")]
        public string Istheleaseconsideredtobesufficientlyadversetodeclinethisproperty { get; set; }

        [JsonProperty("Is there any evidence of commercial or agricultural use?")]
        public string Isthereanyevidenceofcommercialoragriculturaluse { get; set; }

        [JsonProperty("Are you aware of, or suspect there to be any occupancy restrictions?")]
        public string Areyouawareoforsuspecttheretobeanyoccupancyrestrictions { get; set; }

        [JsonProperty("Is the property occupied as a single dwelling?")]
        public string Isthepropertyoccupiedasasingledwelling { get; set; }

        [JsonProperty("Is there an estate rentcharge payable?")]
        public string Isthereanestaterentchargepayable { get; set; }

        [JsonProperty("Are you aware of any low cost home ownership schemes?")]
        public string Areyouawareofanylowcosthomeownershipschemes { get; set; }

        [JsonProperty("Are there any other legal matters needing further investigation?")]
        public string Arethereanyotherlegalmattersneedingfurtherinvestigation { get; set; }

        [JsonProperty("Please select the appropriate construction type for the property's main walls")]
        public string Pleaseselecttheappropriateconstructiontypeforthepropertysmainwalls { get; set; }

        [JsonProperty("Does the plot exceed 1 acre?")]
        public string Doestheplotexceed1acre { get; set; }

        [JsonProperty("Is there any evidence that the property is a Listed Building?")]
        public string IsthereanyevidencethatthepropertyisaListedBuilding { get; set; }

        [JsonProperty("Conservatory type")]
        public string Conservatorytype { get; set; }

        [JsonProperty("Conservatory style")]
        public string Conservatorystyle { get; set; }

        [JsonProperty("Is the property affected by HS2?")]
        public string IsthepropertyaffectedbyHS2 { get; set; }

        [JsonProperty("Are you aware of any adverse site/risk factors?")]
        public string Areyouawareofanyadversesiteriskfactors { get; set; }

        [JsonProperty("Is this a Buy to Let case?")]
        public string IsthisaBuytoLetcase { get; set; }

        [JsonProperty("Assumed year of construction")]
        public string Assumedyearofconstruction { get; set; }

        [JsonProperty("Floors in Property")]
        public string FloorsinProperty { get; set; }

        [JsonProperty("Number of kitchens")]
        public string Numberofkitchens { get; set; }
        public string Bedrooms { get; set; }

        [JsonProperty("Baths (With WC)")]
        public string BathsWithWC { get; set; }

        [JsonProperty("Shower Rooms (With WC)")]
        public string ShowerRoomsWithWC { get; set; }

        [JsonProperty("Separate WCs")]
        public string SeparateWCs { get; set; }
        public string Utility { get; set; }

        [JsonProperty("Accomodation Cellar")]
        public string AccomodationCellar { get; set; }

        [JsonProperty("Outbuilding Cellar")]
        public string OutbuildingCellar { get; set; }

        [JsonProperty("Wine Cellar")]
        public string WineCellar { get; set; }
        public string Receptions { get; set; }
        public string Garage { get; set; }

        [JsonProperty("Specify style of Garage")]
        public string SpecifystyleofGarage { get; set; }

        [JsonProperty("Garage Inspection")]
        public string GarageInspection { get; set; }
        public string Condition { get; set; }

        [JsonProperty("Wall Construction")]
        public string WallConstruction { get; set; }

        [JsonProperty("Roof Construction")]
        public string RoofConstruction { get; set; }

        [JsonProperty("Is there space for a Garage?")]
        public string IstherespaceforaGarage { get; set; }

        [JsonProperty("Parking arrangements (instead of, or additional to, garage)")]
        public string Parkingarrangementsinsteadoforadditionaltogarage { get; set; }

        [JsonProperty("(Assumed) number of parking spaces")]
        public string Assumednumberofparkingspaces { get; set; }
        public string Gardens { get; set; }

        [JsonProperty("Are you aware that the applicant owns any land adjoining the subject property?")]
        public string Areyouawarethattheapplicantownsanylandadjoiningthesubjectproperty { get; set; }

        [JsonProperty("Is Outbuildings none?")]
        public string IsOutbuildingsnone { get; set; }

        [JsonProperty("Site topography is")]
        public string Sitetopographyis { get; set; }

        [JsonProperty("Any trees within influencing distance of the property?")]
        public string Anytreeswithininfluencingdistanceoftheproperty { get; set; }

        [JsonProperty("Distance approximately from the property")]
        public string Distanceapproximatelyfromtheproperty { get; set; }

        [JsonProperty("Specialist Report Required")]
        public string SpecialistReportRequired { get; set; }

        [JsonProperty("Would you like to add tree warning comment into Matters Affecting Value?")]
        public string WouldyouliketoaddtreewarningcommentintoMattersAffectingValue { get; set; }

        [JsonProperty("Are you aware of any structural movement, landslip or heave in the property or in the immediate vicinity?")]
        public string Areyouawareofanystructuralmovementlandsliporheaveinthepropertyorintheimmediatevicinity { get; set; }

        [JsonProperty("Evidence of movement to the property was noted in the form of")]
        public string Evidenceofmovementtothepropertywasnotedintheformof { get; set; }

        [JsonProperty("Does it appear longstanding and unlikely to be progressive?")]
        public string Doesitappearlongstandingandunlikelytobeprogressive { get; set; }

        [JsonProperty("movement relevence Select as appropriate")]
        public string movementrelevenceSelectasappropriate { get; set; }

        [JsonProperty("Is there any reason to believe the property may be at risk of flooding?")]
        public string Isthereanyreasontobelievethepropertymaybeatriskofflooding { get; set; }

        [JsonProperty("Are you aware the property has previously flooded?")]
        public string Areyouawarethepropertyhaspreviouslyflooded { get; set; }

        [JsonProperty("flooding affect")]
        public string floodingaffect { get; set; }

        [JsonProperty("The presence of asbestos is suspected in")]
        public string Thepresenceofasbestosissuspectedin { get; set; }

        [JsonProperty("Evidence of Japanese Knotweed?")]
        public string EvidenceofJapaneseKnotweed { get; set; }

        [JsonProperty("Any adverse site/risk factors?")]
        public string Anyadversesiteriskfactors { get; set; }

        [JsonProperty("Is the property in an area of past/current mining activity?")]
        public string Isthepropertyinanareaofpastcurrentminingactivity { get; set; }

        [JsonProperty("Identify type of mining")]
        public string Identifytypeofmining { get; set; }

        [JsonProperty("Is a mining report required as a condition of the advance?")]
        public string Isaminingreportrequiredasaconditionoftheadvance { get; set; }

        [JsonProperty("Present Condition Value")]
        public string PresentConditionValue { get; set; }

        [JsonProperty("LTV ratio is")]
        public string LTVratiois { get; set; }

        [JsonProperty("Reinstatement Cost")]
        public string ReinstatementCost { get; set; }

        [JsonProperty("Reinstatement Summary")]
        public string ReinstatementSummary { get; set; }

        [JsonProperty("Instructed EV/PP")]
        public string InstructedEVPP { get; set; }
        public string Retention { get; set; }

        [JsonProperty("Retention Value")]
        public string RetentionValue { get; set; }

        [JsonProperty("Value after works complete")]
        public string Valueafterworkscomplete { get; set; }

        [JsonProperty("Suitable as mortgage security")]
        public string Suitableasmortgagesecurity { get; set; }

        [JsonProperty("This property is not suitable for mortgage security because")]
        public string Thispropertyisnotsuitableformortgagesecuritybecause { get; set; }

        [JsonProperty("Any sign of suspicious circumstance/fraud?")]
        public string Anysignofsuspiciouscircumstancefraud { get; set; }

        [JsonProperty("Include request for specialist insurance advice in report?")]
        public string Includerequestforspecialistinsuranceadviceinreport { get; set; }

        [JsonProperty("Rental - Instructed Monthly Rental Value")]
        public string RentalInstructedMonthlyRentalValue { get; set; }

        [JsonProperty("Rental - Letting Suitability")]
        public string RentalLettingSuitability { get; set; }

        [JsonProperty("Rental - Monthly Rental Value")]
        public string RentalMonthlyRentalValue { get; set; }

        [JsonProperty("Rental - Yield (PCV)")]
        public string RentalYieldPCV { get; set; }

        [JsonProperty("Rental - Yield (VAW)")]
        public string RentalYieldVAW { get; set; }
        public string id { get; set; }
        public string _rid { get; set; }
        public string _self { get; set; }
        public string _etag { get; set; }
        public string _attachments { get; set; }
        public int _ts { get; set; }
    }


}