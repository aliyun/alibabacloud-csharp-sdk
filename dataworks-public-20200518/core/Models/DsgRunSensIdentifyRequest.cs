// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgRunSensIdentifyRequest : TeaModel {
        /// <summary>
        /// <para>The list of parameter objects for metadata scanning.</para>
        /// </summary>
        [NameInMap("EsMetaParams")]
        [Validation(Required=false)]
        public List<DsgRunSensIdentifyRequestEsMetaParams> EsMetaParams { get; set; }
        public class DsgRunSensIdentifyRequestEsMetaParams : TeaModel {
            /// <summary>
            /// <para>The cluster ID. You can obtain the ID from your data source cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101010</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values:</para>
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
            /// <para>The instance ID. You can obtain the ID from your data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hgprecn-cn-9lb37k****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Configuration page to obtain the workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16666767566****</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The schema name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table1</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The list of table names.</para>
            /// </summary>
            [NameInMap("TableNameList")]
            [Validation(Required=false)]
            public List<string> TableNameList { get; set; }

            /// <summary>
            /// <para>The username of the operator. We recommend that you enter your Alibaba Cloud account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx-uat</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Data Studio page, click the current username in the upper-right corner, and choose Menu &gt; User Information to obtain the tenant ID.</para>
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
