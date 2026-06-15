// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// <para>The description of the project. This description is displayed in the PAI console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the project. The name must be unique within the instance. It must be 2 to 18 characters long, begin with a letter, and contain only letters, digits, and underscores (<em>). Regex: ^[a-zA-Z][a-zA-Z0-9</em>]+$.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the offline data source, which must be of the <b>MaxCompute</b> type. You can call the ListDatasources operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("OfflineDatasourceId")]
        [Validation(Required=false)]
        public string OfflineDatasourceId { get; set; }

        /// <summary>
        /// <para>The retention period in days for offline tables created by FeatureStore. This setting does not affect existing tables registered with the RegisterTable operation. A default value of 0 means the tables are never automatically deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("OfflineLifeCycle")]
        [Validation(Required=false)]
        public int? OfflineLifeCycle { get; set; }

        /// <summary>
        /// <para>The ID of the online data source. The data source type must be <b>Hologres</b>, <b>Tablestore</b>, or <b>FeatureDB</b>. You can call the ListDatasources operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OnlineDatasourceId")]
        [Validation(Required=false)]
        public string OnlineDatasourceId { get; set; }

        /// <summary>
        /// <para>The ID of the PAI workspace. You can call the <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>324</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
