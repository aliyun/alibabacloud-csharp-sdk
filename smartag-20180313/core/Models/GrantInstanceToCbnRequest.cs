// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GrantInstanceToCbnRequest : TeaModel {
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
        /// <para>The ID of the CEN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-7qthudw0ll6jm*****</para>
        /// </summary>
        [NameInMap("CenInstanceId")]
        [Validation(Required=false)]
        public string CenInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the CEN instance belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1250123456123456</para>
        /// </summary>
        [NameInMap("CenUid")]
        [Validation(Required=false)]
        public long? CenUid { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant the CEN instance permissions to manage network traffic from the CCN instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: grants permissions.</description></item>
        /// <item><description><b>false</b>: does not grant permissions. This is the default value.</description></item>
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
        /// <para>The ID of the region where the CCN instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.htmll">DescribeRegions</a> operation to query the most recent region list.</para>
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

    }

}
