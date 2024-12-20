// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ReleaseInstancePublicConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The type of the endpoint. Default value: primary. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>primary</b>: primary endpoint.</description></item>
        /// <item><description><b>cluster</b>: cluster endpoint. This type of endpoints can be created only for instances that have multiple coordinator nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The public endpoint of the instance.</para>
        /// <para>You can log on to the AnalyticDB for PostgreSQL console and go to the <b>Basic Information</b> page of the instance to view the <b>public endpoint</b> in the <b>Database Connection</b> section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****.gpdb.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CurrentConnectionString")]
        [Validation(Required=false)]
        public string CurrentConnectionString { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

    }

}
