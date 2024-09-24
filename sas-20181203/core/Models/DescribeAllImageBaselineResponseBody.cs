// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAllImageBaselineResponseBody : TeaModel {
        /// <summary>
        /// <para>The baselines that are used in image baseline checks.</para>
        /// </summary>
        [NameInMap("ImageBaselines")]
        [Validation(Required=false)]
        public DescribeAllImageBaselineResponseBodyImageBaselines ImageBaselines { get; set; }
        public class DescribeAllImageBaselineResponseBodyImageBaselines : TeaModel {
            /// <summary>
            /// <para>An array that consists of baseline types.</para>
            /// </summary>
            [NameInMap("BaselineClassList")]
            [Validation(Required=false)]
            public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassList> BaselineClassList { get; set; }
            public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassList : TeaModel {
                /// <summary>
                /// <para>The alias of the baseline type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Identity authentication</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The information about the baseline.</para>
                /// </summary>
                [NameInMap("BaselineNameList")]
                [Validation(Required=false)]
                public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameList> BaselineNameList { get; set; }
                public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameList : TeaModel {
                    /// <summary>
                    /// <para>The alias of the baseline.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Identity authentication</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The information about the baseline check item.</para>
                    /// </summary>
                    [NameInMap("BaselineItemList")]
                    [Validation(Required=false)]
                    public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameListBaselineItemList> BaselineItemList { get; set; }
                    public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameListBaselineItemList : TeaModel {
                        /// <summary>
                        /// <para>The alias of the baseline check item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Ensure that no accounts use the same Hash password.</para>
                        /// </summary>
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        /// <summary>
                        /// <para>The key of the type for the baseline.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>identification</para>
                        /// </summary>
                        [NameInMap("ClassKey")]
                        [Validation(Required=false)]
                        public string ClassKey { get; set; }

                        /// <summary>
                        /// <para>The key of the name for the baseline check item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>duplicate_pwd_hash</para>
                        /// </summary>
                        [NameInMap("ItemKey")]
                        [Validation(Required=false)]
                        public string ItemKey { get; set; }

                        /// <summary>
                        /// <para>The key of the name for the baseline.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>identification</para>
                        /// </summary>
                        [NameInMap("NameKey")]
                        [Validation(Required=false)]
                        public string NameKey { get; set; }

                    }

                    /// <summary>
                    /// <para>The key of the type for the baseline.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>identification</para>
                    /// </summary>
                    [NameInMap("ClassKey")]
                    [Validation(Required=false)]
                    public string ClassKey { get; set; }

                    /// <summary>
                    /// <para>The key of the name for the baseline.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>identification</para>
                    /// </summary>
                    [NameInMap("NameKey")]
                    [Validation(Required=false)]
                    public string NameKey { get; set; }

                }

                /// <summary>
                /// <para>The key of the baseline type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>identification</para>
                /// </summary>
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A975D03-5F49-5354-B2CB-3918D5DA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
