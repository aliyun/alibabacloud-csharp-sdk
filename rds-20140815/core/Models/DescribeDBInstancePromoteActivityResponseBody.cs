// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancePromoteActivityResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22973492**********</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Chinese site: 26842</description></item>
        /// <item><description>International site: 26888</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>26888</para>
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5******</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The dynamic property of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/2391834.html">Instance dynamics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1 (indicates that the target instance is not participating in any promotions)</para>
        /// </summary>
        [NameInMap("IsActivity")]
        [Validation(Required=false)]
        public string IsActivity { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94CB8D93-017A-5AE7-A118-6E0F89D93C0A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
