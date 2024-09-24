// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteSearchConditionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the frequently used search condition.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeSearchCondition~~">DescribeSearchCondition</a> operation to query frequently used search conditions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19.12.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the asset. Default value: ecs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: an Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description><b>cloud_product</b>: an Alibaba Cloud service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
