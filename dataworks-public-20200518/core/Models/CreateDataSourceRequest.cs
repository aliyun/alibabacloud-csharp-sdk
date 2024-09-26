// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The details of the data source. Examples of details of some common data sources:</para>
        /// <list type="bullet">
        /// <item><description><para>odps</para>
        /// <pre><c>{
        ///   &quot;accessId&quot;: &quot;xssssss&quot;,
        ///   &quot;accessKey&quot;: &quot;xsaxsaxsa&quot;,
        ///   &quot;authType&quot;: 2,
        ///   &quot;endpoint&quot;: &quot;http://service.odps.aliyun.com/api&quot;,
        ///   &quot;project&quot;: &quot;xsaxsax&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>mysql</para>
        /// <pre><c>{
        ///   &quot;database&quot;: &quot;xsaxsa&quot;,
        ///   &quot;instanceName&quot;: &quot;rm-xsaxsa&quot;,
        ///   &quot;password&quot;: &quot;xsaxsa&quot;,
        ///   &quot;rdsOwnerId&quot;: &quot;xasxsa&quot;,
        ///   &quot;regionId&quot;: &quot;cn-shanghai&quot;,
        ///   &quot;tag&quot;: &quot;rds&quot;,
        ///   &quot;username&quot;: &quot;xsaxsa&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>rds</para>
        /// <pre><c>{
        ///   &quot;configType&quot;: 1,
        ///   &quot;tag&quot;: &quot;rds&quot;,
        ///   &quot;database&quot;: &quot;xsaxsa&quot;,
        ///   &quot;username&quot;: &quot;xsaxsa&quot;,
        ///   &quot;password&quot;: &quot;xssaxsa$32050&quot;,
        ///   &quot;instanceName&quot;: &quot;rm-xsaxs&quot;,
        ///   &quot;rdsOwnerId&quot;: &quot;11111111&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>oss</para>
        /// <pre><c>{
        ///   &quot;accessId&quot;: &quot;sssssxx&quot;,
        ///   &quot;accessKey&quot;: &quot;xsaxaxsaxs&quot;,
        ///   &quot;bucket&quot;: &quot;xsa-xs-xs&quot;,
        ///   &quot;endpoint&quot;: &quot;http://oss-cn-shanghai.aliyuncs.com&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>sqlserver</para>
        /// <pre><c>{
        ///   &quot;jdbcUrl&quot;: &quot;jdbc:sqlserver://xsaxsa-xsaxsa.database.xxx.cn:123;DatabaseName=xsxs-xsxs&quot;,
        ///   &quot;password&quot;: &quot;sdasda$fs&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;,
        ///   &quot;username&quot;: &quot;sxaxacdacdd&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>polardb</para>
        /// <pre><c>{
        ///   &quot;clusterId&quot;: &quot;pc-sdadsadsa&quot;,
        ///   &quot;database&quot;: &quot;dsadsadsa&quot;,
        ///   &quot;ownerId&quot;: &quot;121212122&quot;,
        ///   &quot;password&quot;: &quot;sdasdafssa&quot;,
        ///   &quot;region&quot;: &quot;cn-shanghai&quot;,
        ///   &quot;tag&quot;: &quot;polardb&quot;,
        ///   &quot;username&quot;: &quot;asdadsads&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>redis</para>
        /// <pre><c>{    
        /// &quot;password&quot;: &quot;xxxxxx&quot;,   
        ///  &quot;address&quot;:&quot;[{\\&quot;host\\&quot;:\\&quot;xxxxxxx.redis.rds.aliyuncs.com\\&quot;,\\&quot;port\\&quot;:6379}]&quot;,    
        /// &quot;tag&quot;: &quot;public&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>oracle</para>
        /// <pre><c>{
        ///   &quot;jdbcUrl&quot;: &quot;jdbc:oracle:saaa:@xxxxx:1521:PROD&quot;,
        ///   &quot;password&quot;: &quot;sxasaxsa&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;,
        ///   &quot;username&quot;: &quot;sasfadfa&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>mongodb</para>
        /// <pre><c>{
        ///   &quot;address&quot;: &quot;[\\&quot;xsaxxsa.mongodb.rds.aliyuncs.com:3717\\&quot;]&quot;,
        ///   &quot;database&quot;: &quot;admin&quot;,
        ///   &quot;password&quot;: &quot;sadsda@&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;,
        ///   &quot;username&quot;: &quot;dsadsadas&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>emr</para>
        /// <pre><c>{
        ///   &quot;accessId&quot;: &quot;xsaxsa&quot;,
        ///   &quot;emrClusterId&quot;: &quot;C-dsads&quot;,
        ///   &quot;emrResourceQueueName&quot;: &quot;default&quot;,
        ///   &quot;emrEndpoint&quot;: &quot;emr.aliyuncs.com&quot;,
        ///   &quot;accessKey&quot;: &quot;dsadsad&quot;,
        ///   &quot;emrUserId&quot;: &quot;224833315798889783&quot;,
        ///   &quot;name&quot;: &quot;sasdsadsa&quot;,
        ///   &quot;emrAccessMode&quot;: &quot;simple&quot;,
        ///   &quot;region&quot;: &quot;cn-shanghai&quot;,
        ///   &quot;authType&quot;: &quot;2&quot;,
        ///   &quot;emrProjectId&quot;: &quot;FP-sdadsad&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>postgresql</para>
        /// <pre><c>{
        ///   &quot;jdbcUrl&quot;: &quot;jdbc:postgresql://xxxx:1921/ssss&quot;,
        ///   &quot;password&quot;: &quot;sdadsads&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;,
        ///   &quot;username&quot;: &quot;sdsasda&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>analyticdb_for_mysql</para>
        /// <pre><c>{
        ///   &quot;instanceId&quot;: &quot;am-sadsada&quot;,
        ///   &quot;database&quot;: &quot;xsxsx&quot;,
        ///   &quot;username&quot;: &quot;xsxsa&quot;,
        ///   &quot;password&quot;: &quot;asdadsa&quot;,
        ///   &quot;connectionString&quot;: &quot;am-xssxsxs.ads.aliyuncs.com:3306&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>hybriddb_for_postgresql</para>
        /// <pre><c>{
        ///   &quot;connectionString&quot;: &quot;gp-xsaxsaxa-master.gpdbmaster.rds.aliyuncs.com&quot;,
        ///   &quot;database&quot;: &quot;xsaxsaxas&quot;,
        ///   &quot;password&quot;: &quot;xsaxsaxsa@11&quot;,
        ///   &quot;instanceId&quot;: &quot;gp-xsaxsaxsa&quot;,
        ///   &quot;port&quot;: &quot;541132&quot;,
        ///   &quot;ownerId&quot;: &quot;xsaxsaxsas&quot;,
        ///   &quot;username&quot;: &quot;sadsad&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>holo</para>
        /// <pre><c>{
        ///   &quot;accessId&quot;: &quot;xsaxsaxs&quot;,
        ///   &quot;accessKey&quot;: &quot;xsaxsaxsa&quot;,
        ///   &quot;database&quot;: &quot;xsaxsaxsa&quot;,
        ///   &quot;instanceId&quot;: &quot;xsaxa&quot;,
        ///   &quot;tag&quot;: &quot;aliyun&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// <item><description><para>kafka</para>
        /// <pre><c>{
        ///   &quot;instanceId&quot;: &quot;xsax-cn-xsaxsa&quot;,
        ///   &quot;regionId&quot;: &quot;cn-shanghai&quot;,
        ///   &quot;tag&quot;: &quot;aliyun&quot;,
        ///   &quot;ownerId&quot;: &quot;1212121212112&quot;
        /// }
        /// </c></pre>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;database&quot;:&quot;dbname&quot;,&quot;instanceName&quot;:&quot;instancename&quot;,&quot;password&quot;:&quot;password&quot;,&quot;rdsOwnerId&quot;:&quot;123&quot;,&quot;username&quot;:&quot;username&quot;}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>odps</description></item>
        /// <item><description>mysql</description></item>
        /// <item><description>rds</description></item>
        /// <item><description>oss</description></item>
        /// <item><description>sqlserver</description></item>
        /// <item><description>polardb</description></item>
        /// <item><description>oracle</description></item>
        /// <item><description>mongodb</description></item>
        /// <item><description>emr</description></item>
        /// <item><description>postgresql</description></item>
        /// <item><description>analyticdb_for_mysql</description></item>
        /// <item><description>hybriddb_for_postgresql</description></item>
        /// <item><description>holo</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The description of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The environment in which the data source is used. Valid values: 0 and 1. The value 0 indicates the development environment. The value 1 indicates the production environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace to which the data source belongs. You can call the <a href="https://help.aliyun.com/document_detail/2780068.html">ListProjects</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The subtype of the data source.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if you set the DataSourceType parameter to rds.</description></item>
        /// <item><description>If the DataSourceType parameter is set to rds, this parameter can be set to mysql, sqlserver, or postgresql.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

    }

}
