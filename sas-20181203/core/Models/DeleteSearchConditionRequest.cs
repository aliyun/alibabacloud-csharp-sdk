// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteSearchConditionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the saved search condition.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSearchCondition~~">DescribeSearchCondition</a> operation to obtain the name.</para>
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
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19.12.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The asset type. Default value: ecs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: host asset</description></item>
        /// <item><description><b>cloud_product</b>: cloud service.</description></item>
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
