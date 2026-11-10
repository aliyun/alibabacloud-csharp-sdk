// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudAccountResourcesForCloudPermissionTemplateRequest : TeaModel {
        /// <summary>
        /// <para>云账号ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789012xxxx</para>
        /// </summary>
        [NameInMap("CloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// <para>按资源实体类型过滤，枚举值：ram_policy。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ram_policy</para>
        /// </summary>
        [NameInMap("CloudAccountResourceEntityType")]
        [Validation(Required=false)]
        public string CloudAccountResourceEntityType { get; set; }

        /// <summary>
        /// <para>权限模板ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpt_xxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateId")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateId { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>分页查询时每页行数。默认值为20，最大值为100。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>查询凭证（Token），取值为上一次API调用返回的NextToken参数值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
