// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DeleteInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The backup retention strategy for cluster deletion. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>receive_all: retains all backup sets.   </description></item>
        /// <item><description>delete_all: deletes all backup sets.   </description></item>
        /// <item><description>receive_last: retains the last backup set.</description></item>
        /// </list>
        /// <remarks>
        /// <para><br>Default value: delete_all.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>delete_all</para>
        /// </summary>
        [NameInMap("BackupRetainMode")]
        [Validation(Required=false)]
        public string BackupRetainMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for the request. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only a dry-run request is sent and the instance is not deleted. If the dry run succeeds, DryRunResult=true is returned. If the dry run fails, an error code is returned.</description></item>
        /// <item><description>false: The actual request is sent and no dry run is performed. The instance is deleted if the requirements are met. By default, false is returned for the parameter DryRunResult if you set DryRun to false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the cluster to be deleted.<br>The value is a string in the JSON format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[”ob ob3f6yhv9uxxxx“]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

    }

}
