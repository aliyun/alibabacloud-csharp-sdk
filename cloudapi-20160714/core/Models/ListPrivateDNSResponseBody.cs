// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ListPrivateDNSResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The internal domain name resolutions.</para>
        /// </summary>
        [NameInMap("PrivateDNSList")]
        [Validation(Required=false)]
        public List<ListPrivateDNSResponseBodyPrivateDNSList> PrivateDNSList { get; set; }
        public class ListPrivateDNSResponseBodyPrivateDNSList : TeaModel {
            /// <summary>
            /// <para>The instances that are associated with the resolution.</para>
            /// </summary>
            [NameInMap("BindInstances")]
            [Validation(Required=false)]
            public List<string> BindInstances { get; set; }

            /// <summary>
            /// <para>The time when the resolution was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-10T08:17:00Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The internal domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api.demo.com</para>
            /// </summary>
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            /// <summary>
            /// <para>The resolution records.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListPrivateDNSResponseBodyPrivateDNSListRecords> Records { get; set; }
            public class ListPrivateDNSResponseBodyPrivateDNSListRecords : TeaModel {
                /// <summary>
                /// <para>The resolution record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.1</para>
                /// </summary>
                [NameInMap("Record")]
                [Validation(Required=false)]
                public string Record { get; set; }

                /// <summary>
                /// <para>The weight of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The internal domain name resolution type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>VPC: resolution for VPC access authorizations. A resolution of this type can be bound only to traditional dedicated instances.</description></item>
            /// <item><description>A: resolution that supports A records. A resolution of this type can be bound only to VPC integration dedicated instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ016</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
