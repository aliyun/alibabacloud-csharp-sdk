// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class SaveApSsidConfigRequest : TeaModel {
        [NameInMap("AcctPort")]
        [Validation(Required=false)]
        public int? AcctPort { get; set; }

        [NameInMap("AcctSecret")]
        [Validation(Required=false)]
        public string AcctSecret { get; set; }

        [NameInMap("AcctServer")]
        [Validation(Required=false)]
        public string AcctServer { get; set; }

        [NameInMap("AcctStatusServerWork")]
        [Validation(Required=false)]
        public int? AcctStatusServerWork { get; set; }

        [NameInMap("ApAssetId")]
        [Validation(Required=false)]
        public long? ApAssetId { get; set; }

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

        [NameInMap("ArpProxyEnable")]
        [Validation(Required=false)]
        public int? ArpProxyEnable { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
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

        [NameInMap("AuthStatusServerWork")]
        [Validation(Required=false)]
        public int? AuthStatusServerWork { get; set; }

        [NameInMap("Cir")]
        [Validation(Required=false)]
        public long? Cir { get; set; }

        [NameInMap("CirStep")]
        [Validation(Required=false)]
        public long? CirStep { get; set; }

        [NameInMap("CirType")]
        [Validation(Required=false)]
        public int? CirType { get; set; }

        [NameInMap("CirUl")]
        [Validation(Required=false)]
        public long? CirUl { get; set; }

        [NameInMap("DaeClient")]
        [Validation(Required=false)]
        public string DaeClient { get; set; }

        [NameInMap("DaePort")]
        [Validation(Required=false)]
        public int? DaePort { get; set; }

        [NameInMap("DaeSecret")]
        [Validation(Required=false)]
        public string DaeSecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public string Disabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DisassocLowAck")]
        [Validation(Required=false)]
        public string DisassocLowAck { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DisassocWeakRssi")]
        [Validation(Required=false)]
        public int? DisassocWeakRssi { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DynamicVlan")]
        [Validation(Required=false)]
        public int? DynamicVlan { get; set; }

        [NameInMap("EncKey")]
        [Validation(Required=false)]
        public string EncKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Encryption")]
        [Validation(Required=false)]
        public string Encryption { get; set; }

        [NameInMap("FourthAuthPort")]
        [Validation(Required=false)]
        public int? FourthAuthPort { get; set; }

        [NameInMap("FourthAuthSecret")]
        [Validation(Required=false)]
        public string FourthAuthSecret { get; set; }

        [NameInMap("FourthAuthServer")]
        [Validation(Required=false)]
        public string FourthAuthServer { get; set; }

        [NameInMap("FtOverDs")]
        [Validation(Required=false)]
        public int? FtOverDs { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Hidden")]
        [Validation(Required=false)]
        public string Hidden { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Ieee80211r")]
        [Validation(Required=false)]
        public int? Ieee80211r { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ieee80211w")]
        [Validation(Required=false)]
        public string Ieee80211w { get; set; }

        [NameInMap("IgnoreWeakProbe")]
        [Validation(Required=false)]
        public int? IgnoreWeakProbe { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Isolate")]
        [Validation(Required=false)]
        public string Isolate { get; set; }

        [NameInMap("LiteEffect")]
        [Validation(Required=false)]
        public bool? LiteEffect { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MaxInactivity")]
        [Validation(Required=false)]
        public int? MaxInactivity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Maxassoc")]
        [Validation(Required=false)]
        public int? Maxassoc { get; set; }

        [NameInMap("MobilityDomain")]
        [Validation(Required=false)]
        public string MobilityDomain { get; set; }

        [NameInMap("MulticastForward")]
        [Validation(Required=false)]
        public int? MulticastForward { get; set; }

        [NameInMap("Nasid")]
        [Validation(Required=false)]
        public string Nasid { get; set; }

        [NameInMap("NdProxyWork")]
        [Validation(Required=false)]
        public int? NdProxyWork { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public int? Network { get; set; }

        [NameInMap("Ownip")]
        [Validation(Required=false)]
        public string Ownip { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RadioIndex")]
        [Validation(Required=false)]
        public string RadioIndex { get; set; }

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

        [NameInMap("SendConfigToAp")]
        [Validation(Required=false)]
        public bool? SendConfigToAp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ShortPreamble")]
        [Validation(Required=false)]
        public string ShortPreamble { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ssid")]
        [Validation(Required=false)]
        public string Ssid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SsidLb")]
        [Validation(Required=false)]
        public int? SsidLb { get; set; }

        [NameInMap("ThirdAuthPort")]
        [Validation(Required=false)]
        public int? ThirdAuthPort { get; set; }

        [NameInMap("ThirdAuthSecret")]
        [Validation(Required=false)]
        public string ThirdAuthSecret { get; set; }

        [NameInMap("ThirdAuthServer")]
        [Validation(Required=false)]
        public string ThirdAuthServer { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VlanDhcp")]
        [Validation(Required=false)]
        public int? VlanDhcp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Wmm")]
        [Validation(Required=false)]
        public string Wmm { get; set; }

    }

}
