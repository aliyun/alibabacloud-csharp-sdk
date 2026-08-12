// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeInstanceConfigsRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether the configuration item can be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowModify")]
        [Validation(Required=false)]
        public bool? AllowModify { get; set; }

        /// <summary>
        /// <para>The key of the configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable_udf</para>
        /// </summary>
        [NameInMap("ConfigKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// <para>The type of the configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>FE</para>
        /// </description></item>
        /// <item><description><para>BE</para>
        /// </description></item>
        /// <item><description><para>CORE</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FE</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The description of the configuration item\&quot;s feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Whether to enable UDF.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether to return all configuration items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedTotal")]
        [Validation(Required=false)]
        public bool? NeedTotal { get; set; }

        /// <summary>
        /// <para>The compute group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-3d5ce6454354****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The page number for the query. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
