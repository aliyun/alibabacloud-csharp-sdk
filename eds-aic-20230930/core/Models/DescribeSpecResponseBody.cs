// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the current read position returned by this call. An empty value means that all data has been read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kw9dGL5jves2FS9RLq****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9888DAD-331E-5FBC-B5A0-F2445115****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specification information.</para>
        /// </summary>
        [NameInMap("SpecInfoModel")]
        [Validation(Required=false)]
        public List<DescribeSpecResponseBodySpecInfoModel> SpecInfoModel { get; set; }
        public class DescribeSpecResponseBodySpecInfoModel : TeaModel {
            /// <summary>
            /// <para>Number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            [NameInMap("MaxPhoneCount")]
            [Validation(Required=false)]
            public string MaxPhoneCount { get; set; }

            /// <summary>
            /// <para>Memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            [NameInMap("MinPhoneCount")]
            [Validation(Required=false)]
            public string MinPhoneCount { get; set; }

            [NameInMap("PhoneCount")]
            [Validation(Required=false)]
            public string PhoneCount { get; set; }

            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <para>Specification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp.basic.small</para>
            /// </summary>
            [NameInMap("SpecId")]
            [Validation(Required=false)]
            public string SpecId { get; set; }

            /// <summary>
            /// <para>Specification status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("SpecStatus")]
            [Validation(Required=false)]
            public string SpecStatus { get; set; }

            /// <summary>
            /// <para>Specification type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ARM</para>
            /// </summary>
            [NameInMap("SpecType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>System disk size, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// <para>Total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
