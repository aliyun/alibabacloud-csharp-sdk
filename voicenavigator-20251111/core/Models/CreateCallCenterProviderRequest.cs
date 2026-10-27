// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateCallCenterProviderRequest : TeaModel {
        /// <summary>
        /// <para>The callee number during the transfer. This parameter is required when the transfer method is Bridge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>153*********</para>
        /// </summary>
        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <para>The display name of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal service provider of Cloud Call Center</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The attached data.</para>
        /// <remarks>
        /// <para>Notice: Format: k1=v1;k2=v2.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1</para>
        /// </summary>
        [NameInMap("Extras")]
        [Validation(Required=false)]
        public string Extras { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36e9a4cd-a821-4f78-86fa-a9a4aefeea2e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal service provider of Cloud Call Center</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The caller number during the transfer. This parameter is required when the transfer method is Bridge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>010****</para>
        /// </summary>
        [NameInMap("Originator")]
        [Validation(Required=false)]
        public string Originator { get; set; }

        /// <summary>
        /// <para>The provider type.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>CCC: Cloud Call Center.</description></item>
        /// <item><description>CUSTOM: Customer-owned call center.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CCC</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// <para>The Refer address.<notice>This parameter is required when the transfer method is Refer.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ReferTo")]
        [Validation(Required=false)]
        public string ReferTo { get; set; }

        /// <summary>
        /// <para>The trunk ID.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required when the transfer method is Bridge.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>trunk-xxx</para>
        /// </summary>
        [NameInMap("TrunkId")]
        [Validation(Required=false)]
        public string TrunkId { get; set; }

    }

}
