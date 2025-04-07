// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The details about the data source. You are not allowed to change the type of the data source. For example, you are not allowed to change the data source type from MaxCompute to MySQL. Examples of details of some common data sources:</para>
        /// <list type="bullet">
        /// <item><description><para>odps</para>
        /// <pre><c>{
        ///   &quot;accessId&quot;: &quot;*****&quot;,
        ///   &quot;accessKey&quot;: &quot;*****&quot;,
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
        ///   &quot;accessId&quot;: &quot;*****&quot;,
        ///   &quot;accessKey&quot;: &quot;*****&quot;,
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
        ///   &quot;accessId&quot;: &quot;*****&quot;,
        ///   &quot;emrClusterId&quot;: &quot;C-dsads&quot;,
        ///   &quot;emrResourceQueueName&quot;: &quot;default&quot;,
        ///   &quot;emrEndpoint&quot;: &quot;emr.aliyuncs.com&quot;,
        ///   &quot;accessKey&quot;: &quot;*****&quot;,
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
        ///   &quot;accessId&quot;: &quot;*****&quot;,
        ///   &quot;accessKey&quot;: &quot;*****&quot;,
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
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;accessId&quot;:&quot;xssssss&quot;,&quot;accessKey&quot;:&quot;xsaxsaxsa&quot;,&quot;authType&quot;:2,&quot;endpoint&quot;:&quot;<a href="http://service.odps.aliyun.com/api%22,%22project%22:%22xsaxsax%22,%22tag%22:%22public%22%7D">http://service.odps.aliyun.com/api&quot;,&quot;project&quot;:&quot;xsaxsax&quot;,&quot;tag&quot;:&quot;public&quot;}</a></para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the data source. You can call the <a href="https://help.aliyun.com/document_detail/2780072.html">ListDataSources</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The description of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The environment in which the data source resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: development environment</description></item>
        /// <item><description>1: production environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// <para>The status of the data source. This parameter is deprecated. Do not use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
