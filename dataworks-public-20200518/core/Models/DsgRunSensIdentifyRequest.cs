// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgRunSensIdentifyRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that you need to configure to scan specified metadata.</para>
        /// </summary>
        [NameInMap("EsMetaParams")]
        [Validation(Required=false)]
        public List<DsgRunSensIdentifyRequestEsMetaParams> EsMetaParams { get; set; }
        public class DsgRunSensIdentifyRequestEsMetaParams : TeaModel {
            /// <summary>
            /// <para>The cluster ID. You can obtain the ID based on the data source you use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101010</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ODPS.ODPS</description></item>
            /// <item><description>EMR</description></item>
            /// <item><description>HOLO.POSTGRES</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS.ODPS</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The instance ID. You can obtain the ID based on the data source you use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hgprecn-cn-9lb37k181024</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1666676756691024</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The name of the schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table1</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The names of the tables.</para>
            /// </summary>
            [NameInMap("TableNameList")]
            [Validation(Required=false)]
            public List<string> TableNameList { get; set; }

            /// <summary>
            /// <para>The username of the operator. We recommend that you enter the username of your Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx-uat</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID. To obtain the tenant ID, perform the following steps: Log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. Find your workspace and go to the DataStudio page. On the DataStudio page, click the logon username in the upper-right corner and click User Info in the Menu section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10241024</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
