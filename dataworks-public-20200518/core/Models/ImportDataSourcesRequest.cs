// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ImportDataSourcesRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the data sources that you want to import. The Name, DataSourceType, SubType, Description, Content, and EnvType parameters are required. For more information about the parameters, see <a href="https://help.aliyun.com/document_detail/211429.html">CreateDataSource</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SubType&quot;:&quot;&quot;,&quot;DataSourceType&quot;:&quot;mysql&quot;,&quot;EnvType&quot;:1,&quot;Name&quot;:&quot;mysql_dms2&quot;,&quot;Description&quot;:&quot;aaa&quot;,&quot;Content&quot;:&quot;{\&quot;database\&quot;:\&quot;mysql_chengdu_old\&quot;,\&quot;password\&quot;:\&quot;<em><b>\&quot;,\&quot;instanceName\&quot;:\&quot;rm-2vcrckb37163g7l3w\&quot;,\&quot;regionId\&quot;:\&quot;cn-chengdu\&quot;,\&quot;tag\&quot;:\&quot;rds\&quot;,\&quot;rdsOwnerId\&quot;:\&quot;333\&quot;,\&quot;username\&quot;:\&quot;mysql_chengdu2\&quot;}&quot;},{&quot;SubType&quot;:&quot;&quot;,&quot;DataSourceType&quot;:&quot;mysql&quot;,&quot;EnvType&quot;:1,&quot;Name&quot;:&quot;mysql_dms2&quot;,&quot;Description&quot;:&quot;aaa&quot;,&quot;Content&quot;:&quot;{\&quot;database\&quot;:\&quot;mysql_chengdu_old\&quot;,\&quot;password\&quot;:\&quot;</b></em>\&quot;,\&quot;instanceName\&quot;:\&quot;rm-2vcrckb37163g7l3w\&quot;,\&quot;regionId\&quot;:\&quot;cn-chengdu\&quot;,\&quot;tag\&quot;:\&quot;rds\&quot;,\&quot;rdsOwnerId\&quot;:\&quot;143\&quot;,\&quot;username\&quot;:\&quot;mysql_chengdu2\&quot;}&quot;}]</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public string DataSources { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
