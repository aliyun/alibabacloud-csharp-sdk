// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class DescribeScreenDataMapResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-XXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SasScreenTypeList")]
        [Validation(Required=false)]
        public List<DescribeScreenDataMapResponseBodySasScreenTypeList> SasScreenTypeList { get; set; }
        public class DescribeScreenDataMapResponseBodySasScreenTypeList : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASSETS</para>
            /// </summary>
            [NameInMap("TypeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }

            [NameInMap("TypeData")]
            [Validation(Required=false)]
            public List<DescribeScreenDataMapResponseBodySasScreenTypeListTypeData> TypeData { get; set; }
            public class DescribeScreenDataMapResponseBodySasScreenTypeListTypeData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>VUL_VUL</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Date")]
                [Validation(Required=false)]
                public List<DescribeScreenDataMapResponseBodySasScreenTypeListTypeDataDate> Date { get; set; }
                public class DescribeScreenDataMapResponseBodySasScreenTypeListTypeDataDate : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>second</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
