// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeParameterTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The parameter level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>compute</b>: compute layer.</description></item>
        /// <item><description><b>storage</b>: storage layer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("ParamLevel")]
        [Validation(Required=false)]
        public string ParamLevel { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
