// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCalcEnginesResponseBody : TeaModel {
        /// <summary>
        /// <para>The query results for compute engines that are returned on multiple pages.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCalcEnginesResponseBodyData Data { get; set; }
        public class ListCalcEnginesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The compute engines.</para>
            /// </summary>
            [NameInMap("CalcEngines")]
            [Validation(Required=false)]
            public List<ListCalcEnginesResponseBodyDataCalcEngines> CalcEngines { get; set; }
            public class ListCalcEnginesResponseBodyDataCalcEngines : TeaModel {
                /// <summary>
                /// <para>The ID of the workspace with which the compute engine is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("BindingProjectId")]
                [Validation(Required=false)]
                public int? BindingProjectId { get; set; }

                /// <summary>
                /// <para>The name of the workspace with which the compute engine is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("BindingProjectName")]
                [Validation(Required=false)]
                public string BindingProjectName { get; set; }

                /// <summary>
                /// <para>The type of the compute engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS</para>
                /// </summary>
                [NameInMap("CalcEngineType")]
                [Validation(Required=false)]
                public string CalcEngineType { get; set; }

                /// <summary>
                /// <para>The region where the DataWorks workspace with which the compute engine is associated resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou</para>
                /// </summary>
                [NameInMap("DwRegion")]
                [Validation(Required=false)]
                public string DwRegion { get; set; }

                /// <summary>
                /// <para>The compute engine ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35</para>
                /// </summary>
                [NameInMap("EngineId")]
                [Validation(Required=false)]
                public int? EngineId { get; set; }

                /// <summary>
                /// <para>The details of the compute engine.</para>
                /// <list type="bullet">
                /// <item><description><para>ODPS</para>
                /// <pre><c>{
                ///   &quot;pubEndpoint&quot;: &quot;service.cn.maxcompute.aliyun.com/api&quot;,
                ///   &quot;endpoint&quot;: &quot;service.cn.maxcompute.aliyun-inc.com/api&quot;,
                ///   &quot;initProperties&quot;: &quot; 
                ///   {\\&quot;odpsTypeMode\\&quot;:\\&quot;STANDARD\\&quot;,\\&quot;openPai\\&quot;:false,\\&quot;openPaiGpu\\&quot;:false}&quot;,
                ///   &quot;resourceGroupType&quot;: &quot;ODPS&quot;,
                ///   &quot;resourceGroupId&quot;: &quot;361826516****&quot;,
                ///   &quot;vpcEndpoint&quot;: &quot;service.cn.maxcompute.aliyun-inc.com/api&quot;,
                ///   &quot;projectName&quot;: &quot;onefall_test_zjk&quot;,
                ///   &quot;taskSameAsOwner&quot;: &quot;true&quot;
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>EMR</para>
                /// <pre><c>{
                ///   &quot;emrClusterId&quot;: &quot;C-xxx&quot;,
                ///   &quot;specs&quot;: &quot;{\\&quot;emrClusterId\\&quot;:\\&quot;C-xxx\\&quot;,\\&quot;emrAccessMode\\&quot;:\\&quot;simple\\&quot;,\\&quot;emrResourceQueueName\\&quot;:\\&quot;default\\&quot;,\\&quot;emrProjectId\\&quot;:\\&quot;FP-xxx\\&quot;}&quot;,
                ///   &quot;endpoint&quot;: &quot;emr.aliyuncs.com&quot;,
                ///   &quot;emrResourceQueueName&quot;: &quot;default&quot;,
                ///   &quot;emrAccessMode&quot;: &quot;simple&quot;,
                ///   &quot;resourceGroupType&quot;: &quot;DW&quot;,
                ///   &quot;projectName&quot;: &quot;xx-xxxx&quot;,
                ///   &quot;emrProjectId&quot;: &quot;FP-xxxx&quot;,
                ///   &quot;taskSameAsOwner&quot;: &quot;false&quot;
                /// }   
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>BLINK</para>
                /// <pre><c>{
                ///   &quot;bayesProjectId&quot;: &quot;xxxx&quot;,
                ///   &quot;bayesProjectName&quot;: &quot;xc_blxxixxxnk_1&quot;,
                ///   &quot;cluster&quot;: &quot;xxxssxsx&quot;,
                ///   &quot;endpoint&quot;: &quot;https://stream.console.aliyun.com&quot;,
                ///   &quot;engineType&quot;: &quot;BLINK&quot;,
                ///   &quot;name&quot;: &quot;xsxsxxxxx&quot;,
                ///   &quot;projectName&quot;: &quot;xc_blxxxsxink_1&quot;,
                ///   &quot;queue&quot;: &quot;root.xc_blxsxxxxxxink_1&quot;,
                ///   &quot;resourceGroupType&quot;: &quot;DW&quot;,
                ///   &quot;specs&quot;: &quot;{\\&quot;cluster\\&quot;:\\&quot;xxxxxx\\&quot;,\\&quot;bayesProjectName\\&quot;:\\&quot;xc_blxxixxxnk_1\\&quot;,\\&quot;bayesProjectId\\&quot;:\\&quot;ssxxxsa\\&quot;,\\&quot;name\\&quot;:\\&quot;sxsxsxxx\\&quot;,\\&quot;queue\\&quot;:\\&quot;root.sxxsxxsx\\&quot;}&quot;,
                ///   &quot;taskSameAsOwner&quot;: false
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>HOLO</para>
                /// <pre><c>{
                ///   &quot;endpoint&quot;: &quot;hgprecn-cn-xsxssxsx-cn-shanghai-internal.hologres.aliyuncs.com:80&quot;,
                ///   &quot;engineType&quot;: &quot;ODPS&quot;,
                ///   &quot;odpsEndpoint&quot;: &quot;hgprecn-cn-xsxssxxs-cn-shanghai-internal.hologres.aliyuncs.com:80&quot;,
                ///   &quot;odpsProjectName&quot;: &quot;xsxssxsxsx&quot;,
                ///   &quot;projectName&quot;: &quot;xsxssxsxsx&quot;,
                ///   &quot;resourceGroupType&quot;: &quot;DW&quot;,
                ///   &quot;specs&quot;: &quot;{\\&quot;pubEndpoint\\&quot;:\\&quot;hgprecn-cn-xsxssxsxs-cn-shanghai.hologres.aliyuncs.com:80\\&quot;,\\&quot;commonBuyInstanceId\\&quot;:\\&quot;hgprecn-cn-xsxsxsxs\\&quot;,\\&quot;project\\&quot;:\\&quot;holo_upxsxgrade1\\&quot;,\\&quot;common_buy_instance_id\\&quot;:\\&quot;hgprecn-cn-xsxsxs\\&quot;,\\&quot;endpoint\\&quot;:\\&quot;hgprecn-cn-xsxxsxs-cn-shanghai-internal.hologres.aliyuncs.com:80\\&quot;,\\&quot;port\\&quot;:\\&quot;80\\&quot;,\\&quot;host\\&quot;:\\&quot;hgprecn-cn-xsxsxsxs-cn-shanghai-internal.hologres.aliyuncs.com\\&quot;,\\&quot;vpcEndpoint\\&quot;:\\&quot;hgprecn-cn-xsxsxsxs-cn-shanghai-vpc.hologres.aliyuncs.com:80\\&quot;,\\&quot;authType\\&quot;:2,\\&quot;region\\&quot;:\\&quot;cn-shanghai\\&quot;}&quot;,
                ///   &quot;taskSameAsOwner&quot;: false
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>MaxGraph</para>
                /// <pre><c>{
                ///   &quot;endpoint&quot;: &quot;http://pre-graphcompute.aliyuncs.com&quot;,
                ///   &quot;engineType&quot;: &quot;ODPS&quot;,
                ///   &quot;odpsEndpoint&quot;: &quot;http://pre-graphcompute.aliyuncs.com&quot;,
                ///   &quot;odpsProjectName&quot;: &quot;xsxsxsxs&quot;,
                ///   &quot;projectName&quot;: &quot;xsxsxsxs&quot;,
                ///   &quot;resourceGroupType&quot;: &quot;DW&quot;,
                ///   &quot;taskSameAsOwner&quot;: false
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>HYBRIDDB_FOR_POSTGRESQL</para>
                /// <pre><c>{
                ///   &quot;endpoint&quot;: &quot;hybriddb_for_postgresql_mo12121ck_endpoint&quot;,
                ///   &quot;engineType&quot;: &quot;ODPS&quot;,
                ///   &quot;odpsEndpoint&quot;: &quot;hybriddb_for_postgresql_m121212ock_endpoint&quot;,
                ///   &quot;odpsProjectName&quot;: &quot;sxasaxsaxaxas&quot;,
                ///   &quot;projectName&quot;: &quot;sxasaxsaxaxas&quot;,
                ///   &quot;resourceGroupType&quot;: &quot;DW&quot;,
                ///   &quot;specs&quot;: &quot;{\\&quot;connectionString\\&quot;:\\&quot;gp-xsxsxsxxs.gpdb.rds.aliyuncs.com\\&quot;,\\&quot;database\\&quot;:\\&quot;xsxsxxsxs\\&quot;,\\&quot;password\\&quot;:\\&quot;xxxxxxx\\&quot;,\\&quot;instanceId\\&quot;:\\&quot;gp-cdcdacdacda\\&quot;,\\&quot;port\\&quot;:\\&quot;3432\\&quot;,\\&quot;ownerId\\&quot;:\\&quot;12121212\\&quot;,\\&quot;username\\&quot;:\\&quot;sdasaddsa\\&quot;}&quot;,
                ///   &quot;taskSameAsOwner&quot;: false
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>ADB_MYSQL</para>
                /// <pre><c>{
                ///   &quot;endpoint&quot;: &quot;adb_mysql_mock_endpoint&quot;,
                ///   &quot;engineType&quot;: &quot;ODPS&quot;,
                ///   &quot;odpsEndpoint&quot;: &quot;adb_mysql_mock_endpoint&quot;,
                ///   &quot;odpsProjectName&quot;: &quot;am-xsaxaxa&quot;,
                ///   &quot;projectName&quot;: &quot;am-xsxsaxa&quot;,
                ///   &quot;resourceGroupType&quot;: &quot;DW&quot;,
                ///   &quot;specs&quot;: &quot;{\\&quot;connectionString\\&quot;:\\&quot;am-xsaxsa.ads.aliyuncs.com:3306\\&quot;,\\&quot;database\\&quot;:\\&quot;xsaxsaxa\\&quot;,\\&quot;password\\&quot;:\\&quot;xsaxsaxassxsa\\&quot;,\\&quot;instanceId\\&quot;:\\&quot;am-xsaxsasx\\&quot;,\\&quot;username\\&quot;:\\&quot;xsaxsadsd\\&quot;}&quot;,
                ///   &quot;taskSameAsOwner&quot;: false
                /// }
                /// </c></pre>
                /// </description></item>
                /// <item><description><para>HADOOP_CDH</para>
                /// <pre><c>{
                ///   &quot;bindingBaseId&quot;: &quot;xsaxsaxs&quot;,
                ///   &quot;endpoint&quot;: &quot;xsaaaaa&quot;,
                ///   &quot;engineType&quot;: &quot;ODPS&quot;,
                ///   &quot;odpsEndpoint&quot;: &quot;axsxaxssxs&quot;,
                ///   &quot;odpsProjectName&quot;: &quot;ssxxax&quot;,
                ///   &quot;projectName&quot;: &quot;xsaxsaxsa&quot;,
                ///   &quot;resourceGroupId&quot;: 45208xxxxxx,
                ///   &quot;resourceGroupType&quot;: &quot;GATEWAY&quot;,
                ///   &quot;specs&quot;: &quot;{\\&quot;cluster\\&quot;:{\\&quot;hive\\&quot;:{\\&quot;hiveServer2Url\\&quot;:\\&quot;jdbc:hive2://xxxxxxer-1-cn-shanghai-pre-kerberos-1:10000\\&quot;,\\&quot;hiveMetastore\\&quot;:\\&quot;thrift://xxxxxxxr-1-cn-shanghai-pre-kerberos-1:9083\\&quot;,\\&quot;version\\&quot;:\\&quot;2.1.1\\&quot;},\\&quot;configFiles\\&quot;:{\\&quot;coreSite\\&quot;:\\&quot;4534574xxxxxx\\&quot;,\\&quot;hdfsSite\\&quot;:\\&quot;453457919xxxxxxx\\&quot;,\\&quot;mapredSite\\&quot;:\\&quot;45345750xxxxxx\\&quot;,\\&quot;yarnSite\\&quot;:\\&quot;4534575xxxxx\\&quot;,\\&quot;krb5Conf\\&quot;:\\&quot;4534576xxxxx1\\&quot;,\\&quot;hiveSite\\&quot;:\\&quot;453457xxxxx20\\&quot;},\\&quot;spark\\&quot;:{\\&quot;version\\&quot;:\\&quot;2.4.0\\&quot;},\\&quot;cdh\\&quot;:{\\&quot;version\\&quot;:\\&quot;6.3.2\\&quot;},\\&quot;hdfs\\&quot;:{\\&quot;version\\&quot;:\\&quot;3.0.0\\&quot;},\\&quot;impala\\&quot;:{\\&quot;impalaUrl\\&quot;:\\&quot;jdbc:impala://cdh-xsxssxxsx-1-cn-shanghai-pre-kerberos-1:21050\\&quot;,\\&quot;version\\&quot;:\\&quot;3.2.0\\&quot;},\\&quot;yarn\\&quot;:{\\&quot;YarnUrl\\&quot;:\\&quot;http://cdh-xsxsxsxsxs-1-cn-shanghai-pre-kerberos-1:8032\\&quot;,\\&quot;webUrl\\&quot;:\\&quot;http://cdh-xsxsxssxxssx-1-cn-shanghai-pre-kerberos-1:8088\\&quot;,\\&quot;version\\&quot;:\\&quot;3.0.0\\&quot;},\\&quot;presto\\&quot;:{\\&quot;prestoUrl\\&quot;:\\&quot;jdbc:presto://cdh-xssxsxxsxsxs-1-cn-shanghai-pre-kerberos-1:8080/hive/default\\&quot;,\\&quot;version\\&quot;:\\&quot;0.244.1\\&quot;}},\\&quot;instanceId\\&quot;:161sdads733,\\&quot;authDetail\\&quot;:{\\&quot;principal\\&quot;:\\&quot;hive@HADOOP.COM\\&quot;,\\&quot;keytabFileId\\&quot;:\\&quot;45345815xsxsxs3\\&quot;,\\&quot;type\\&quot;:\\&quot;kerberos\\&quot;,\\&quot;username\\&quot;:\\&quot;xsxsxsxsa@HADOOP.COM\\&quot;},\\&quot;resGroupStatus\\&quot;:\\&quot;\\&quot;,\\&quot;hadoopAuthType\\&quot;:\\&quot;kerberos\\&quot;,\\&quot;clusterIdentifier\\&quot;:\\&quot;xssxsxsxsx\\&quot;,\\&quot;clusterId\\&quot;:xsxsx,\\&quot;resGroupId\\&quot;:4520870619xsxssxxs,\\&quot;accessMode\\&quot;:\\&quot;security\\&quot;,\\&quot;authType\\&quot;:2}&quot;,
                ///   &quot;taskSameAsOwner&quot;: false
                /// }
                /// </c></pre>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;pubEndpoint&quot;:&quot;<a href="http://service.cn.maxcompute.aliyun.com/api%22,%22endpoint%22:%22http://service.cn.maxcompute.aliyun-inc.com/api%22,%22resourceGroupType%22:%22ODPS%22,%22resourceGroupId%22:%22361826516****%22,%22vpcEndpoint%22:%22http://service.cn.maxcompute.aliyun-inc.com/api%22,%22projectName%22:%22onefall_test_zjk%22,%22taskSameAsOwner%22:%22true%22%7D">http://service.cn.maxcompute.aliyun.com/api&quot;,&quot;endpoint&quot;:&quot;http://service.cn.maxcompute.aliyun-inc.com/api&quot;,&quot;resourceGroupType&quot;:&quot;ODPS&quot;,&quot;resourceGroupId&quot;:&quot;361826516****&quot;,&quot;vpcEndpoint&quot;:&quot;http://service.cn.maxcompute.aliyun-inc.com/api&quot;,&quot;projectName&quot;:&quot;onefall_test_zjk&quot;,&quot;taskSameAsOwner&quot;:&quot;true&quot;}</a></para>
                /// </summary>
                [NameInMap("EngineInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> EngineInfo { get; set; }

                /// <summary>
                /// <para>The environment in which the compute engine is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DEV</b></description></item>
                /// <item><description><b>PRD</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PRD</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The time when the compute engine was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Oct 10, 2019 3:42:44 PM</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Indicates whether the compute engine is the default engine of the current type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The display name of the compute engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The region where the compute engine resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The identity that is used to access the compute engine. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>USER</b>: the current user</description></item>
                /// <item><description><b>PROJECT</b>: the workspace executor</description></item>
                /// <item><description><b>SUBACCOUNT</b>: a RAM user</description></item>
                /// <item><description><b>STS_ROLE</b>: the Security Token Service (STS) role</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PROJECT</para>
                /// </summary>
                [NameInMap("TaskAuthType")]
                [Validation(Required=false)]
                public string TaskAuthType { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of compute engine instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec92159376****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
