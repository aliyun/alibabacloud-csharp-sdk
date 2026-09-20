// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetManualDagInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the DAG instance that triggers the manual workflow. You can call the <a href="https://help.aliyun.com/document_detail/189728.html">CreateManualDag</a> operation to obtain instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000001231241</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public string DagId { get; set; }

        /// <summary>
        /// <para>The environment identifier of the Operation Center. Valid values: PROD (production environment) and DEV (development environment).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPOD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The name of the workspace to which the manual workflow belongs. You can obtain the name on the workspace configuration page in the DataWorks console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_workspace</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
