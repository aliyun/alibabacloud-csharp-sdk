// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListVendorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. If this is your first query or if no next page exists, you do not need to specify this parameter. If a next page exists, set the value to the NextToken value that is returned in the last response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The vendors.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<ListVendorsResponseBodyVendors> Vendors { get; set; }
        public class ListVendorsResponseBodyVendors : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The vendor ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vd-qlsw5eocx94w9</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

            /// <summary>
            /// <para>The vendor name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

            /// <summary>
            /// <para>The vendor type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>preset</para>
            /// </description></item>
            /// <item><description><para>custom</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("VendorType")]
            [Validation(Required=false)]
            public string VendorType { get; set; }

        }

    }

}
