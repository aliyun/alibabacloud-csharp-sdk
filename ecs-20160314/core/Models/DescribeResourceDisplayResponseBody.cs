// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeResourceDisplayResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceDisplay")]
        [Validation(Required=false)]
        public DescribeResourceDisplayResponseBodyResourceDisplay ResourceDisplay { get; set; }
        public class DescribeResourceDisplayResponseBodyResourceDisplay : TeaModel {
            [NameInMap("InstanceCategories")]
            [Validation(Required=false)]
            public DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategories InstanceCategories { get; set; }
            public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategories : TeaModel {
                [NameInMap("InstanceCategory")]
                [Validation(Required=false)]
                public List<DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategory> InstanceCategory { get; set; }
                public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategory : TeaModel {
                    [NameInMap("CategoryType")]
                    [Validation(Required=false)]
                    public string CategoryType { get; set; }

                    [NameInMap("InstanceTopCategories")]
                    [Validation(Required=false)]
                    public DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategories InstanceTopCategories { get; set; }
                    public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategories : TeaModel {
                        [NameInMap("InstanceTopCategory")]
                        [Validation(Required=false)]
                        public List<DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategory> InstanceTopCategory { get; set; }
                        public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategory : TeaModel {
                            [NameInMap("InstanceSecondCategories")]
                            [Validation(Required=false)]
                            public DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategories InstanceSecondCategories { get; set; }
                            public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategories : TeaModel {
                                [NameInMap("InstanceSecondCategory")]
                                [Validation(Required=false)]
                                public List<DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategoriesInstanceSecondCategory> InstanceSecondCategory { get; set; }
                                public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategoriesInstanceSecondCategory : TeaModel {
                                    [NameInMap("InstanceTypeFamilies")]
                                    [Validation(Required=false)]
                                    public DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategoriesInstanceSecondCategoryInstanceTypeFamilies InstanceTypeFamilies { get; set; }
                                    public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategoriesInstanceSecondCategoryInstanceTypeFamilies : TeaModel {
                                        [NameInMap("InstanceTypeFamily")]
                                        [Validation(Required=false)]
                                        public List<DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategoriesInstanceSecondCategoryInstanceTypeFamiliesInstanceTypeFamily> InstanceTypeFamily { get; set; }
                                        public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategoriesInstanceSecondCategoryInstanceTypeFamiliesInstanceTypeFamily : TeaModel {
                                            [NameInMap("InstanceTypeFamilyId")]
                                            [Validation(Required=false)]
                                            public string InstanceTypeFamilyId { get; set; }

                                            [NameInMap("Tags")]
                                            [Validation(Required=false)]
                                            public DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategoriesInstanceSecondCategoryInstanceTypeFamiliesInstanceTypeFamilyTags Tags { get; set; }
                                            public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryInstanceTopCategoriesInstanceTopCategoryInstanceSecondCategoriesInstanceSecondCategoryInstanceTypeFamiliesInstanceTypeFamilyTags : TeaModel {
                                                [NameInMap("Tag")]
                                                [Validation(Required=false)]
                                                public List<string> Tag { get; set; }

                                            }

                                        }

                                    }

                                    [NameInMap("SecondCategoryLevel")]
                                    [Validation(Required=false)]
                                    public string SecondCategoryLevel { get; set; }

                                }

                            }

                            [NameInMap("TopCategoryLevel")]
                            [Validation(Required=false)]
                            public string TopCategoryLevel { get; set; }

                        }

                    }

                    [NameInMap("ZoneIds")]
                    [Validation(Required=false)]
                    public DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryZoneIds ZoneIds { get; set; }
                    public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceCategoriesInstanceCategoryZoneIds : TeaModel {
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public List<string> ZoneId { get; set; }

                    }

                }

            }

            [NameInMap("InstanceChargeTypes")]
            [Validation(Required=false)]
            public DescribeResourceDisplayResponseBodyResourceDisplayInstanceChargeTypes InstanceChargeTypes { get; set; }
            public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceChargeTypes : TeaModel {
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public List<DescribeResourceDisplayResponseBodyResourceDisplayInstanceChargeTypesInstanceChargeType> InstanceChargeType { get; set; }
                public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceChargeTypesInstanceChargeType : TeaModel {
                    [NameInMap("ChargeType")]
                    [Validation(Required=false)]
                    public string ChargeType { get; set; }

                    [NameInMap("SpotStrategy")]
                    [Validation(Required=false)]
                    public string SpotStrategy { get; set; }

                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public DescribeResourceDisplayResponseBodyResourceDisplayInstanceChargeTypesInstanceChargeTypeTags Tags { get; set; }
                    public class DescribeResourceDisplayResponseBodyResourceDisplayInstanceChargeTypesInstanceChargeTypeTags : TeaModel {
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public List<string> Tag { get; set; }

                    }

                }

            }

            [NameInMap("ProductCategories")]
            [Validation(Required=false)]
            public DescribeResourceDisplayResponseBodyResourceDisplayProductCategories ProductCategories { get; set; }
            public class DescribeResourceDisplayResponseBodyResourceDisplayProductCategories : TeaModel {
                [NameInMap("ProductCategory")]
                [Validation(Required=false)]
                public List<DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategory> ProductCategory { get; set; }
                public class DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategory : TeaModel {
                    [NameInMap("InstanceFamilyGroups")]
                    [Validation(Required=false)]
                    public DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroups InstanceFamilyGroups { get; set; }
                    public class DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroups : TeaModel {
                        [NameInMap("InstanceFamilyGroup")]
                        [Validation(Required=false)]
                        public List<DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroupsInstanceFamilyGroup> InstanceFamilyGroup { get; set; }
                        public class DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroupsInstanceFamilyGroup : TeaModel {
                            [NameInMap("InstanceFamilyGroupName")]
                            [Validation(Required=false)]
                            public string InstanceFamilyGroupName { get; set; }

                            [NameInMap("InstanceTypeFamilies")]
                            [Validation(Required=false)]
                            public DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroupsInstanceFamilyGroupInstanceTypeFamilies InstanceTypeFamilies { get; set; }
                            public class DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroupsInstanceFamilyGroupInstanceTypeFamilies : TeaModel {
                                [NameInMap("InstanceTypeFamily")]
                                [Validation(Required=false)]
                                public List<DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroupsInstanceFamilyGroupInstanceTypeFamiliesInstanceTypeFamily> InstanceTypeFamily { get; set; }
                                public class DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroupsInstanceFamilyGroupInstanceTypeFamiliesInstanceTypeFamily : TeaModel {
                                    [NameInMap("InstanceTypeFamilyId")]
                                    [Validation(Required=false)]
                                    public string InstanceTypeFamilyId { get; set; }

                                    [NameInMap("Tags")]
                                    [Validation(Required=false)]
                                    public DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroupsInstanceFamilyGroupInstanceTypeFamiliesInstanceTypeFamilyTags Tags { get; set; }
                                    public class DescribeResourceDisplayResponseBodyResourceDisplayProductCategoriesProductCategoryInstanceFamilyGroupsInstanceFamilyGroupInstanceTypeFamiliesInstanceTypeFamilyTags : TeaModel {
                                        [NameInMap("Tag")]
                                        [Validation(Required=false)]
                                        public List<string> Tag { get; set; }

                                    }

                                }

                            }

                        }

                    }

                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                }

            }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public DescribeResourceDisplayResponseBodyResourceDisplayZones Zones { get; set; }
            public class DescribeResourceDisplayResponseBodyResourceDisplayZones : TeaModel {
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public List<DescribeResourceDisplayResponseBodyResourceDisplayZonesZone> Zone { get; set; }
                public class DescribeResourceDisplayResponseBodyResourceDisplayZonesZone : TeaModel {
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public DescribeResourceDisplayResponseBodyResourceDisplayZonesZoneTags Tags { get; set; }
                    public class DescribeResourceDisplayResponseBodyResourceDisplayZonesZoneTags : TeaModel {
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public List<string> Tag { get; set; }

                    }

                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

        }

    }

}
