// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpConfig : TeaModel {
        [NameInMap("AttrMapConfig")]
        [Validation(Required=false)]
        public IdpAttrMapConfig AttrMapConfig { get; set; }

        [NameInMap("ConnectConfig")]
        [Validation(Required=false)]
        public IdpConnectConfig ConnectConfig { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DingtalkConfig")]
        [Validation(Required=false)]
        public IdpDingtalkSubConfig DingtalkConfig { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("FeishuConfig")]
        [Validation(Required=false)]
        public IdpFeishuSubConfig FeishuConfig { get; set; }

        [NameInMap("IdaasConfig")]
        [Validation(Required=false)]
        public IdpIdaas2SubConfig IdaasConfig { get; set; }

        [NameInMap("IdpConfigId")]
        [Validation(Required=false)]
        public string IdpConfigId { get; set; }

        [NameInMap("LastSyncTimeUnix")]
        [Validation(Required=false)]
        public long? LastSyncTimeUnix { get; set; }

        [NameInMap("LdapConfig")]
        [Validation(Required=false)]
        public IdpLdapSubConfig LdapConfig { get; set; }

        [NameInMap("LoginConfig")]
        [Validation(Required=false)]
        public IdpLoginConfig LoginConfig { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SyncConfig")]
        [Validation(Required=false)]
        public IdpSyncConfig SyncConfig { get; set; }

        [NameInMap("SyncStatus")]
        [Validation(Required=false)]
        public string SyncStatus { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("WeixinConfig")]
        [Validation(Required=false)]
        public IdpWeixin2SubConfig WeixinConfig { get; set; }

        [NameInMap("WuyingConfig")]
        [Validation(Required=false)]
        public OpenStructIdpWuyingSubConfig WuyingConfig { get; set; }

    }

}
