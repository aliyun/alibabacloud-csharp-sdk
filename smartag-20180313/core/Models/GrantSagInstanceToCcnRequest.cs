// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GrantSagInstanceToCcnRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CCN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn-n2935s1mnwv8i*****</para>
        /// </summary>
        [NameInMap("CcnInstanceId")]
        [Validation(Required=false)]
        public string CcnInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the CCN instance belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("CcnUid")]
        [Validation(Required=false)]
        public long? CcnUid { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant the CCN instance permissions to manage network traffic from the SAG instance.</para>
        /// <para>After the CCN instance is granted the permissions, the CCN instance can redirect the network traffic sent from the SAG instance to the Internet to Cloud Security Access Service (CSAS) for security audit.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: grants permissions.</description></item>
        /// <item><description><b>false</b>: does not grant permissions.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the value to true and the SAG instance connected to the CCN instance has the secure rerouting feature enabled, you cannot revoke the permissions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GrantTrafficService")]
        [Validation(Required=false)]
        public bool? GrantTrafficService { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SAG instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-tzirqx07bvcngm****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

    }

}
