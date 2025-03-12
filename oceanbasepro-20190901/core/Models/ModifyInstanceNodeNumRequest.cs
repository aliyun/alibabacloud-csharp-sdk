// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyInstanceNodeNumRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform only a dry run for the request. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only a dry-run request is sent and the number of nodes in the instance is not modified. If the dry run succeeds, DryRunResult=true is returned. If the dry run fails, an error code is returned.</description></item>
        /// <item><description>false: The actual request is sent and no dry run is performed. The number of nodes is changed if the requirements are met. By default, the DryRunResult parameter returns false if you set DryRun to false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of nodes in the cluster. If the cluster is deployed in n-n-n mode, the number of nodes in the cluster equals n × 3.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("NodeNum")]
        [Validation(Required=false)]
        public string NodeNum { get; set; }

    }

}
