// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListLaboratoriesRequest : TeaModel {
        /// <summary>
        /// <para>The laboratory environment.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Daily</c>: the daily environment</para>
        /// </description></item>
        /// <item><description><para><c>Pre</c>: the pre-production environment</para>
        /// </description></item>
        /// <item><description><para><c>Prod</c>: the production environment</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can obtain this ID by calling the <c>ListInstances</c> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the scene. You can obtain this ID by calling the <c>ListScenes</c> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The laboratory status.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Offline</c>: The laboratory is offline.</para>
        /// </description></item>
        /// <item><description><para><c>Online</c>: The laboratory is online.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Offline</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
