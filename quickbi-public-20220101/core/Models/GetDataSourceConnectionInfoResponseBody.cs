// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetDataSourceConnectionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7AAB95D-*****-****-*4FC0C976</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Data source information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetDataSourceConnectionInfoResponseBodyResult Result { get; set; }
        public class GetDataSourceConnectionInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Database connection string address (domain or IP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.<b>.</b>.48</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>Permission level:</para>
            /// <list type="bullet">
            /// <item><description>0 -- Private</description></item>
            /// <item><description>1 -- Collaborative Editing (old)</description></item>
            /// <item><description>11 -- Collaborative Editing - Space Members</description></item>
            /// <item><description>12 -- Collaborative Editing - Specified to Individuals</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AuthLevel")]
            [Validation(Required=false)]
            public string AuthLevel { get; set; }

            /// <summary>
            /// <para>Quick BI user ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>U240****0880C6095</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>Data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a201c85c-******</para>
            /// </summary>
            [NameInMap("DsId")]
            [Validation(Required=false)]
            public string DsId { get; set; }

            /// <summary>
            /// <para>Data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("DsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }

            /// <summary>
            /// <para>Version of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("DsVersion")]
            [Validation(Required=false)]
            public string DsVersion { get; set; }

            /// <summary>
            /// <para>Database instance, corresponding to the database name, and for ODPS, it is the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm*********t44ju1</para>
            /// </summary>
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm*********t44ju1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Quick BI user ID of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>U240****0880C6095</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>Whether the impala data source requires authentication to log in:</para>
            /// <list type="bullet">
            /// <item><description>true - Requires account and password login  </description></item>
            /// <item><description>false - No authentication required (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NoSasl")]
            [Validation(Required=false)]
            public bool? NoSasl { get; set; }

            /// <summary>
            /// <para>Primary data source type for multi-engine data sources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataphin</para>
            /// </summary>
            [NameInMap("ParentDsType")]
            [Validation(Required=false)]
            public string ParentDsType { get; set; }

            /// <summary>
            /// <para>Port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>Used for front-end display when obtaining connection details for ODPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-ossdoc</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>Database schema, only needs to be set for databases that support schemas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Analysis</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>Display name of the data source on the front end.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0327</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>Workspace ID to which the data source belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0de6<b>2-d</b>-4720-8836-0cc****1394c</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
