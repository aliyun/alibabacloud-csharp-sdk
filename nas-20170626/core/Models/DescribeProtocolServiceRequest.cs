// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeProtocolServiceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How do I ensure the idempotence?</a></para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description or a part of the description of the protocol service.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain letters, digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The number of results for each query.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100.</description></item>
        /// <item><description>Minimum value: 10.</description></item>
        /// <item><description>Default value: 20.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aBcdg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the protocol service.</para>
        /// <list type="bullet">
        /// <item><description>Format: CSV.</description></item>
        /// <item><description>Limit: You can specify a maximum of 10 protocol service IDs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ptc-197ed6a00f2b****,ptc-196ed6a00f2b****</para>
        /// </summary>
        [NameInMap("ProtocolServiceIds")]
        [Validation(Required=false)]
        public string ProtocolServiceIds { get; set; }

        /// <summary>
        /// <para>The status of the protocol service.</para>
        /// <para>Format: CSV.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The protocol service is being created.</description></item>
        /// <item><description>Starting: The protocol service is being started.</description></item>
        /// <item><description>Running: The protocol service is running.</description></item>
        /// <item><description>Updating: The protocol service is being updated.</description></item>
        /// <item><description>Deleting: The protocol service is being deleted.</description></item>
        /// <item><description>Stopping: The protocol service is being stopped.</description></item>
        /// <item><description>Stopped: The protocol service is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running,Updating</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
