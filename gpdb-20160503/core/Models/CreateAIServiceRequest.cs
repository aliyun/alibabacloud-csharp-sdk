// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateAIServiceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to list all AnalyticDB for PostgreSQL instances in the destination region, including their instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>A description of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dramatest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A comma-separated list of IP addresses or CIDR blocks in the IP address whitelist. You can specify up to 1000 entries. To block all external IP access, use 127.0.0.1. Valid formats include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>10.23.12.24 (an IPv4 address)</para>
        /// </description></item>
        /// <item><description><para>10.23.12.24/24 (a CIDR block, where /24 indicates the prefix length, from 1 to 32)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After you create the service, call the ModifyAIServiceSecurityIps operation to update the IP address whitelist.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The service account. It must meet these requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Contain only lowercase letters, digits, and underscores.</para>
        /// </description></item>
        /// <item><description><para>Start with a lowercase letter and end with a lowercase letter or digit.</para>
        /// </description></item>
        /// <item><description><para>Not start with gp.</para>
        /// </description></item>
        /// <item><description><para>Be 2 to 16 characters long.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dramauser</para>
        /// </summary>
        [NameInMap("ServiceAccount")]
        [Validation(Required=false)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// <para>The password for the service account. It must meet these requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Contain at least three of the following: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>Support these special characters: !@#$%^&amp;\*()_+-=.</para>
        /// </description></item>
        /// <item><description><para>Be 8 to 32 characters long.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456Aa!</para>
        /// </summary>
        [NameInMap("ServiceAccountPassword")]
        [Validation(Required=false)]
        public string ServiceAccountPassword { get; set; }

        /// <summary>
        /// <para>The service type. Only drama is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drama</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
