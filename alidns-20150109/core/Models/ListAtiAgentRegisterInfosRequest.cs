// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListAtiAgentRegisterInfosRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试Agent</para>
        /// </summary>
        [NameInMap("AgentDisplayName")]
        [Validation(Required=false)]
        public string AgentDisplayName { get; set; }

        /// <summary>
        /// <para>The host address of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("AgentHost")]
        [Validation(Required=false)]
        public string AgentHost { get; set; }

        /// <summary>
        /// <para>The Agent ID, which is uniformly assigned by CNNIC after real-name verification through CNNIC. The AgentID serves as the unique identifier that binds the Agent to the real-name verified registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liuq@azt400</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The version of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>Ensures the idempotency of the request. Generate a unique parameter value from your client to ensure that the value is unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4698691</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number. Minimum value: 1. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size for the paged query. This parameter specifies the number of entries per page for paging.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>活跃</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
