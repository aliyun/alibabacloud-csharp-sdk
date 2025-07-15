// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetSnapshotCallbackAuthRequest : TeaModel {
        /// <summary>
        /// <para>The custom key that is used for callback authentication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourkey</para>
        /// </summary>
        [NameInMap("CallbackAuthKey")]
        [Validation(Required=false)]
        public string CallbackAuthKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable callback authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: enables callback authentication.</description></item>
        /// <item><description><b>no</b>: disables callback authentication.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("CallbackReqAuth")]
        [Validation(Required=false)]
        public string CallbackReqAuth { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
