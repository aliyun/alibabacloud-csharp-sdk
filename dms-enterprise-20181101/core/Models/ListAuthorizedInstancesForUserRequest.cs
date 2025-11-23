// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAuthorizedInstancesForUserRequest : TeaModel {
        /// <summary>
        /// <para>The type of databases. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>DRDS</b></description></item>
        /// <item><description><b>OceanBase</b></description></item>
        /// <item><description><b>Mongo</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The type of the environment in which the database instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>product</b>: production environment.</description></item>
        /// <item><description><b>dev</b>: development environment.</description></item>
        /// <item><description><b>pre</b>: pre-release environment.</description></item>
        /// <item><description><b>test</b>: test environment.</description></item>
        /// <item><description><b>sit</b>: system integration testing (SIT) environment.</description></item>
        /// <item><description><b>uat</b>: user acceptance testing (UAT) environment.</description></item>
        /// <item><description><b>pet</b>: stress testing environment.</description></item>
        /// <item><description><b>stag</b>: staging environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy_test</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the ID of the tenant, go to the DMS console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The ID of the user. You can call the <a href="https://help.aliyun.com/document_detail/465816.html">GetUser</a> operation to query the user ID.</para>
        /// <remarks>
        /// <para>If IdentityType is set to USER, this parameter is required.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
