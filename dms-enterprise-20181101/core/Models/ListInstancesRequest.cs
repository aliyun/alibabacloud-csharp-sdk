// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the database. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The type of the environment to which the database instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>product:</b> production environment</description></item>
        /// <item><description><b>dev</b>: development environment</description></item>
        /// <item><description><b>pre</b>: pre-release environment</description></item>
        /// <item><description><b>test</b>: test environment</description></item>
        /// <item><description><b>sit</b>: system integration testing (SIT) environment</description></item>
        /// <item><description><b>uat</b>: user acceptance testing (UAT) environment</description></item>
        /// <item><description><b>pet</b>: stress testing environment</description></item>
        /// <item><description><b>stag:</b> staging environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The source of the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC_OWN</b>: a self-managed database instance that is deployed on the Internet</description></item>
        /// <item><description><b>RDS</b>: an ApsaraDB RDS instance</description></item>
        /// <item><description><b>ECS_OWN</b>: a self-managed database that is deployed on an Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>VPC_IDC</b>: a self-managed database instance that is deployed in a data center connected over a virtual private cloud (VPC)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceSource")]
        [Validation(Required=false)]
        public string InstanceSource { get; set; }

        /// <summary>
        /// <para>The status of the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b></description></item>
        /// <item><description><b>DISABLE</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("InstanceState")]
        [Validation(Required=false)]
        public string InstanceState { get; set; }

        /// <summary>
        /// <para>The network type of the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLASSIC:</b> classic network</description></item>
        /// <item><description><b>VPC:</b> VPC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The number cannot exceed 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The keyword that is used to search for database instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
