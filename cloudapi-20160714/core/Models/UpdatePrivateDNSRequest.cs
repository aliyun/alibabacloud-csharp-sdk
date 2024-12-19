// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class UpdatePrivateDNSRequest : TeaModel {
        /// <summary>
        /// <para>The internal domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.demo.com</para>
        /// </summary>
        [NameInMap("IntranetDomain")]
        [Validation(Required=false)]
        public string IntranetDomain { get; set; }

        /// <summary>
        /// <para>The resolution records. This parameter is valid only when Type is set to A.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<UpdatePrivateDNSRequestRecords> Records { get; set; }
        public class UpdatePrivateDNSRequestRecords : TeaModel {
            /// <summary>
            /// <para>The resolution record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.2</para>
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The internal domain name resolution type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VPC: resolution for virtual private cloud (VPC) access authorizations. A resolution of this type can be bound only to traditional dedicated instances.</description></item>
        /// <item><description>A: resolution that supports A records. A resolution of this type can be bound only to VPC integration dedicated instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
