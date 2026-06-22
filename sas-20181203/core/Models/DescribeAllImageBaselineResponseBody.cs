// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAllImageBaselineResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the image baseline check list.</para>
        /// </summary>
        [NameInMap("ImageBaselines")]
        [Validation(Required=false)]
        public DescribeAllImageBaselineResponseBodyImageBaselines ImageBaselines { get; set; }
        public class DescribeAllImageBaselineResponseBodyImageBaselines : TeaModel {
            /// <summary>
            /// <para>The list of baseline categories.</para>
            /// </summary>
            [NameInMap("BaselineClassList")]
            [Validation(Required=false)]
            public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassList> BaselineClassList { get; set; }
            public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassList : TeaModel {
                /// <summary>
                /// <para>The alias of the baseline category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>身份鉴别</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The list of baseline main items.</para>
                /// </summary>
                [NameInMap("BaselineNameList")]
                [Validation(Required=false)]
                public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameList> BaselineNameList { get; set; }
                public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameList : TeaModel {
                    /// <summary>
                    /// <para>The alias of the baseline main item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>身份鉴别</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The list of baseline sub-items.</para>
                    /// </summary>
                    [NameInMap("BaselineItemList")]
                    [Validation(Required=false)]
                    public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameListBaselineItemList> BaselineItemList { get; set; }
                    public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameListBaselineItemList : TeaModel {
                        /// <summary>
                        /// <para>The alias of the baseline sub-item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>确保不存在相同密码Hash的账户</para>
                        /// </summary>
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        /// <summary>
                        /// <para>The type key of the baseline main item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>identification</para>
                        /// </summary>
                        [NameInMap("ClassKey")]
                        [Validation(Required=false)]
                        public string ClassKey { get; set; }

                        /// <summary>
                        /// <para>The name key of the baseline sub-item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>duplicate_pwd_hash</para>
                        /// </summary>
                        [NameInMap("ItemKey")]
                        [Validation(Required=false)]
                        public string ItemKey { get; set; }

                        /// <summary>
                        /// <para>The name key of the baseline main item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>identification</para>
                        /// </summary>
                        [NameInMap("NameKey")]
                        [Validation(Required=false)]
                        public string NameKey { get; set; }

                    }

                    /// <summary>
                    /// <para>The type key of the baseline main item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>identification</para>
                    /// </summary>
                    [NameInMap("ClassKey")]
                    [Validation(Required=false)]
                    public string ClassKey { get; set; }

                    /// <summary>
                    /// <para>The name key of the baseline main item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>identification</para>
                    /// </summary>
                    [NameInMap("NameKey")]
                    [Validation(Required=false)]
                    public string NameKey { get; set; }

                }

                /// <summary>
                /// <para>The type key of the baseline category.</para>
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
        /// <para>The ID of the request. The ID is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A975D03-5F49-5354-B2CB-3918D5DA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
