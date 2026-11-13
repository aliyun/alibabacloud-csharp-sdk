// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListManualDagInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directed acyclic graph (DAG) for the manually executed business flow. You can call the <a href="https://help.aliyun.com/document_detail/212830.html">RunManualDagNodes</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000001231241</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public string DagId { get; set; }

        /// <summary>
        /// <para>The scheduling environment of Operation Center. PROD specifies production, and DEV specifies development.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPOD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The name of the workspace to which the manually executed business flow belongs. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the name.</para>
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
