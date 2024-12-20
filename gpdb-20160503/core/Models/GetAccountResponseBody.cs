// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The new description of the database account.</para>
        /// <list type="bullet">
        /// <item><description>The description must start with a letter.</description></item>
        /// <item><description>The description cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain letters, underscores (_), hyphens (-), and digits.</description></item>
        /// <item><description>The description must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The instance used by this account to log in is DBInstanceId. The name used to log in is AccountName.</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the initial account.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>The name must start with a lowercase letter and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name cannot start with gp.</description></item>
        /// <item><description>The name must be 2 to 16 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testaccount</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The status of the member that you want to query.</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: managed.</description></item>
        /// <item><description><b>disabled</b>: not managed.</description></item>
        /// <item><description><b>disabling</b>: being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccountStatus")]
        [Validation(Required=false)]
        public string AccountStatus { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Normal: standard account</description></item>
        /// <item><description>Super: privileged account</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA7E4276-E2D5-5F8D-AF06-9EAB3F6C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
