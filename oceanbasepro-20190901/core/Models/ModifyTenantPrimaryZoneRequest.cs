// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantPrimaryZoneRequest : TeaModel {
        /// <summary>
        /// <para>The primary zone of the tenant.<br>It is one of the zones in which the cluster is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <pre><c>http(s)://[Endpoint]/?Action=ModifyTenantPrimaryZone
        /// &amp;TenantId=ob2mr3oae0****
        /// &amp;InstanceId=ob317v4uif****
        /// &amp;PrimaryZone=cn-hangzhou-h
        /// &amp;Common request parameters
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("MasterIntranetAddressZone")]
        [Validation(Required=false)]
        public string MasterIntranetAddressZone { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        [NameInMap("TenantEndpointDirectId")]
        [Validation(Required=false)]
        public string TenantEndpointDirectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>obe-4tw51gp7****</para>
        /// </summary>
        [NameInMap("TenantEndpointId")]
        [Validation(Required=false)]
        public string TenantEndpointId { get; set; }

        /// <summary>
        /// <para>The return result of the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob2mr3oae0****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UserDirectVSwitchId")]
        [Validation(Required=false)]
        public string UserDirectVSwitchId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxx</para>
        /// </summary>
        [NameInMap("UserVSwitchId")]
        [Validation(Required=false)]
        public string UserVSwitchId { get; set; }

        [NameInMap("UserVpcOwnerId")]
        [Validation(Required=false)]
        public string UserVpcOwnerId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
