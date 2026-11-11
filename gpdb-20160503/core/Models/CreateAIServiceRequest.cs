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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance IDs.</para>
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
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dramatest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IP addresses in IP address whitelist. You can add up to 1,000 IP addresses, separated by commas (,). A value of 127.0.0.1 specifies that access from all external IP addresses is denied. Valid formats:</para>
        /// <list type="bullet">
        /// <item><description>10.23.12.24 (IP address)</description></item>
        /// <item><description>10.23.12.24/24 (CIDR block. /24 specifies the length of the prefix in the IP address. The prefix length ranges from 1 to 32.)</description></item>
        /// </list>
        /// <remarks>
        /// <para>After the service is created, you can call the ModifyAIServiceSecurityIps operation to modify IP address whitelist.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The service account. The account must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>It must start with a lowercase letter and end with a lowercase letter or a digit.</description></item>
        /// <item><description>It cannot start with gp.</description></item>
        /// <item><description>It must be 2 to 16 characters in length.</description></item>
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
        /// <para>The password of the service account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>Supported special characters: !@#$%^&amp;*()_+-=</description></item>
        /// <item><description>It must be 8 to 32 characters in length.</description></item>
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
        /// <para>The service type. Currently, only drama is supported.</para>
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
