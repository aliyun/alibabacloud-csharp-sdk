// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The data source ID. You can call the <a href="https://help.aliyun.com/document_detail/173911.html">ListConnections</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public long? ConnectionId { get; set; }

        /// <summary>
        /// <para>The details of the data source. Examples of details of some common data sources:</para>
        /// <list type="bullet">
        /// <item><description>odps</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///   &quot;accessId&quot;: &quot;xssssss&quot;,
        ///   &quot;accessKey&quot;: &quot;xsaxsaxsa&quot;,
        ///   &quot;authType&quot;: 2,
        ///   &quot;endpoint&quot;: &quot;http://service.odps.aliyun.com/api&quot;,
        ///   &quot;project&quot;: &quot;xsaxsax&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>mysql</description></item>
        /// </list>
        /// <!---->
        /// 
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
        /// <list type="bullet">
        /// <item><description>rds</description></item>
        /// </list>
        /// <!---->
        /// 
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
        /// <list type="bullet">
        /// <item><description>oss</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///   &quot;accessId&quot;: &quot;sssssxx&quot;,
        ///   &quot;accessKey&quot;: &quot;xsaxaxsaxs&quot;,
        ///   &quot;bucket&quot;: &quot;xsa-xs-xs&quot;,
        ///   &quot;endpoint&quot;: &quot;http://oss-cn-shanghai.aliyuncs.com&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>sqlserver</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///   &quot;jdbcUrl&quot;: &quot;jdbc:sqlserver://xsaxsa-xsaxsa.database.xxx.cn:123;DatabaseName=xsxs-xsxs&quot;,
        ///   &quot;password&quot;: &quot;sdasda$fs&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;,
        ///   &quot;username&quot;: &quot;sxaxacdacdd&quot;
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>polardb</description></item>
        /// </list>
        /// <!---->
        /// 
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
        /// <list type="bullet">
        /// <item><description>oracle</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///   &quot;jdbcUrl&quot;: &quot;jdbc:oracle:saaa:@xxxxx:1521:PROD&quot;,
        ///   &quot;password&quot;: &quot;sxasaxsa&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;,
        ///   &quot;username&quot;: &quot;sasfadfa&quot;
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>mongodb</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///   &quot;address&quot;: &quot;[\\&quot;xsaxxsa.mongodb.rds.aliyuncs.com:3717\\&quot;]&quot;,
        ///   &quot;database&quot;: &quot;admin&quot;,
        ///   &quot;password&quot;: &quot;sadsda@&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;,
        ///   &quot;username&quot;: &quot;dsadsadas&quot;
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>emr</description></item>
        /// </list>
        /// <!---->
        /// 
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
        /// <list type="bullet">
        /// <item><description>postgresql</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///   &quot;jdbcUrl&quot;: &quot;jdbc:postgresql://xxxx:1921/ssss&quot;,
        ///   &quot;password&quot;: &quot;sdadsads&quot;,
        ///   &quot;tag&quot;: &quot;public&quot;,
        ///   &quot;username&quot;: &quot;sdsasda&quot;
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>analyticdb_for_mysql</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///   &quot;instanceId&quot;: &quot;am-sadsada&quot;,
        ///   &quot;database&quot;: &quot;xsxsx&quot;,
        ///   &quot;username&quot;: &quot;xsxsa&quot;,
        ///   &quot;password&quot;: &quot;asdadsa&quot;,
        ///   &quot;connectionString&quot;: &quot;am-xssxsxs.ads.aliyuncs.com:3306&quot;
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>hybriddb_for_postgresql</description></item>
        /// </list>
        /// <!---->
        /// 
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
        /// <list type="bullet">
        /// <item><description>holo</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///   &quot;accessId&quot;: &quot;xsaxsaxs&quot;,
        ///   &quot;accessKey&quot;: &quot;xsaxsaxsa&quot;,
        ///   &quot;database&quot;: &quot;xsaxsaxsa&quot;,
        ///   &quot;instanceId&quot;: &quot;xsaxa&quot;,
        ///   &quot;tag&quot;: &quot;aliyun&quot;
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>kafka</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///   &quot;instanceId&quot;: &quot;xsax-cn-xsaxsa&quot;,
        ///   &quot;regionId&quot;: &quot;cn-shanghai&quot;,
        ///   &quot;tag&quot;: &quot;aliyun&quot;,
        ///   &quot;ownerId&quot;: &quot;1212121212112&quot;
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;database&quot;:&quot;dbname&quot;,&quot;instanceName&quot;:&quot;instancename&quot;,&quot;password&quot;:&quot;password&quot;,&quot;rdsOwnerId&quot;:&quot;123&quot;,&quot;username&quot;:&quot;username&quot;}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// <para>The status of the data source. Valid values: ENABLED and DISABLED. The value ENABLED indicates that the data source is in the normal state. The value DISABLED indicates that the data source is in an abnormal state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
