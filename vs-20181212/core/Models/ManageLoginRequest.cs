// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ManageLoginRequest : TeaModel {
        /// <summary>
        /// <para>Name of the management action. Valid values:</para>
        /// <ol>
        /// <item><description><para>open — Activate the public key. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>close — Deactivate the public key.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// <para>Name of the public key group. If you do not specify KeyName, all public keys in this group are applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mygroup</para>
        /// </summary>
        [NameInMap("KeyGroup")]
        [Validation(Required=false)]
        public string KeyGroup { get; set; }

        /// <summary>
        /// <para>Name of the public key. You must specify either KeyName or KeyGroup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mykey</para>
        /// </summary>
        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        /// <summary>
        /// <para>ID of the Cloud Application Service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
