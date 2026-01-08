// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class MoveContactToGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizExtend { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:1}]</para>
        /// </summary>
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public string Contacts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:1}]</para>
        /// </summary>
        [NameInMap("LinkExistGroups")]
        [Validation(Required=false)]
        public string LinkExistGroups { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;groupName&quot;:&quot;aaa&quot;}]</para>
        /// </summary>
        [NameInMap("LinkNewGroups")]
        [Validation(Required=false)]
        public string LinkNewGroups { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
