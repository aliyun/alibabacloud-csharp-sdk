// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class SaveApgroupSsidConfigRequest : TeaModel {
        [NameInMap("AcctPort")]
        [Validation(Required=false)]
        public int? AcctPort { get; set; }

        [NameInMap("AcctSecret")]
        [Validation(Required=false)]
        public string AcctSecret { get; set; }

        [NameInMap("AcctServer")]
        [Validation(Required=false)]
        public string AcctServer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApgroupId")]
        [Validation(Required=false)]
        public string ApgroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AuthCache")]
        [Validation(Required=false)]
        public string AuthCache { get; set; }

        [NameInMap("AuthPort")]
        [Validation(Required=false)]
        public int? AuthPort { get; set; }

        [NameInMap("AuthSecret")]
        [Validation(Required=false)]
        public string AuthSecret { get; set; }

        [NameInMap("AuthServer")]
        [Validation(Required=false)]
        public string AuthServer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Binding")]
        [Validation(Required=false)]
        public string Binding { get; set; }

        [NameInMap("Cir")]
        [Validation(Required=false)]
        public long? Cir { get; set; }

        [NameInMap("DaeClient")]
        [Validation(Required=false)]
        public string DaeClient { get; set; }

        [NameInMap("DaePort")]
        [Validation(Required=false)]
        public int? DaePort { get; set; }

        [NameInMap("DaeSecret")]
        [Validation(Required=false)]
        public string DaeSecret { get; set; }

        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public string Disabled { get; set; }

        [NameInMap("DisassocLowAck")]
        [Validation(Required=false)]
        public string DisassocLowAck { get; set; }

        [NameInMap("DisassocWeakRssi")]
        [Validation(Required=false)]
        public int? DisassocWeakRssi { get; set; }

        [NameInMap("DynamicVlan")]
        [Validation(Required=false)]
        public int? DynamicVlan { get; set; }

        [NameInMap("Effect")]
        [Validation(Required=false)]
        public bool? Effect { get; set; }

        [NameInMap("EncKey")]
        [Validation(Required=false)]
        public string EncKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Encryption")]
        [Validation(Required=false)]
        public string Encryption { get; set; }

        [NameInMap("Hidden")]
        [Validation(Required=false)]
        public string Hidden { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Ieee80211w")]
        [Validation(Required=false)]
        public string Ieee80211w { get; set; }

        [NameInMap("IgnoreWeakProbe")]
        [Validation(Required=false)]
        public int? IgnoreWeakProbe { get; set; }

        [NameInMap("Isolate")]
        [Validation(Required=false)]
        public string Isolate { get; set; }

        [NameInMap("LiteEffect")]
        [Validation(Required=false)]
        public bool? LiteEffect { get; set; }

        [NameInMap("MaxInactivity")]
        [Validation(Required=false)]
        public int? MaxInactivity { get; set; }

        [NameInMap("Maxassoc")]
        [Validation(Required=false)]
        public string Maxassoc { get; set; }

        [NameInMap("MulticastForward")]
        [Validation(Required=false)]
        public int? MulticastForward { get; set; }

        [NameInMap("Nasid")]
        [Validation(Required=false)]
        public string Nasid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public int? Network { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NewSsid")]
        [Validation(Required=false)]
        public string NewSsid { get; set; }

        [NameInMap("Ownip")]
        [Validation(Required=false)]
        public string Ownip { get; set; }

        [NameInMap("SecondaryAcctPort")]
        [Validation(Required=false)]
        public int? SecondaryAcctPort { get; set; }

        [NameInMap("SecondaryAcctSecret")]
        [Validation(Required=false)]
        public string SecondaryAcctSecret { get; set; }

        [NameInMap("SecondaryAcctServer")]
        [Validation(Required=false)]
        public string SecondaryAcctServer { get; set; }

        [NameInMap("SecondaryAuthPort")]
        [Validation(Required=false)]
        public int? SecondaryAuthPort { get; set; }

        [NameInMap("SecondaryAuthSecret")]
        [Validation(Required=false)]
        public string SecondaryAuthSecret { get; set; }

        [NameInMap("SecondaryAuthServer")]
        [Validation(Required=false)]
        public string SecondaryAuthServer { get; set; }

        [NameInMap("ShortPreamble")]
        [Validation(Required=false)]
        public string ShortPreamble { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ssid")]
        [Validation(Required=false)]
        public string Ssid { get; set; }

        [NameInMap("SsidLb")]
        [Validation(Required=false)]
        public int? SsidLb { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("VlanDhcp")]
        [Validation(Required=false)]
        public int? VlanDhcp { get; set; }

        [NameInMap("Wmm")]
        [Validation(Required=false)]
        public string Wmm { get; set; }

    }

}
