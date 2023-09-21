// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAllImageBaselineResponseBody : TeaModel {
        /// <summary>
        /// The baselines that are used in image baseline checks.
        /// </summary>
        [NameInMap("ImageBaselines")]
        [Validation(Required=false)]
        public DescribeAllImageBaselineResponseBodyImageBaselines ImageBaselines { get; set; }
        public class DescribeAllImageBaselineResponseBodyImageBaselines : TeaModel {
            /// <summary>
            /// An array that consists of baseline types.
            /// </summary>
            [NameInMap("BaselineClassList")]
            [Validation(Required=false)]
            public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassList> BaselineClassList { get; set; }
            public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassList : TeaModel {
                /// <summary>
                /// The alias of the baseline type.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The information about the baseline.
                /// </summary>
                [NameInMap("BaselineNameList")]
                [Validation(Required=false)]
                public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameList> BaselineNameList { get; set; }
                public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameList : TeaModel {
                    /// <summary>
                    /// The alias of the baseline.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The information about the baseline check item.
                    /// </summary>
                    [NameInMap("BaselineItemList")]
                    [Validation(Required=false)]
                    public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameListBaselineItemList> BaselineItemList { get; set; }
                    public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameListBaselineItemList : TeaModel {
                        /// <summary>
                        /// The alias of the baseline check item.
                        /// </summary>
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        /// <summary>
                        /// The key of the type for the baseline.
                        /// </summary>
                        [NameInMap("ClassKey")]
                        [Validation(Required=false)]
                        public string ClassKey { get; set; }

                        /// <summary>
                        /// The key of the name for the baseline check item.
                        /// </summary>
                        [NameInMap("ItemKey")]
                        [Validation(Required=false)]
                        public string ItemKey { get; set; }

                        /// <summary>
                        /// The key of the name for the baseline.
                        /// </summary>
                        [NameInMap("NameKey")]
                        [Validation(Required=false)]
                        public string NameKey { get; set; }

                    }

                    /// <summary>
                    /// The key of the type for the baseline.
                    /// </summary>
                    [NameInMap("ClassKey")]
                    [Validation(Required=false)]
                    public string ClassKey { get; set; }

                    /// <summary>
                    /// The key of the name for the baseline.
                    /// </summary>
                    [NameInMap("NameKey")]
                    [Validation(Required=false)]
                    public string NameKey { get; set; }

                }

                /// <summary>
                /// The key of the baseline type.
                /// </summary>
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request, which is used to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
