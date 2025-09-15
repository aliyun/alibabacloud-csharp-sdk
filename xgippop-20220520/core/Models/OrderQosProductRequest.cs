// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XgipPop20220520.Models
{
    public class OrderQosProductRequest : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("IPv6")]
        [Validation(Required=false)]
        public string IPv6 { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        [NameInMap("MobileNumber")]
        [Validation(Required=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("PrivateIpv4")]
        [Validation(Required=false)]
        public string PrivateIpv4 { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("Provice")]
        [Validation(Required=false)]
        public string Provice { get; set; }

        [NameInMap("PublicIpv4")]
        [Validation(Required=false)]
        public string PublicIpv4 { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("QosRequestId")]
        [Validation(Required=false)]
        public string QosRequestId { get; set; }

        [NameInMap("TargetIpList")]
        [Validation(Required=false)]
        public List<string> TargetIpList { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("UnitNum")]
        [Validation(Required=false)]
        public int? UnitNum { get; set; }

    }

}
