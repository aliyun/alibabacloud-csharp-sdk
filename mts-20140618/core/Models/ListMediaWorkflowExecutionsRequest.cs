// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListMediaWorkflowExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>The Object Storage Service (OSS) URL of the input file of the media workflow. The URL complies with RFC 3986 and is encoded in UTF-8, with reserved characters being percent-encoded. For more information, see <a href="https://help.aliyun.com/document_detail/423796.html">URL encoding</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-****.cn-hangzhou.aliyuncs.com/test****.flv">http://example-****.cn-hangzhou.aliyuncs.com/test****.flv</a></para>
        /// </summary>
        [NameInMap("InputFileURL")]
        [Validation(Required=false)]
        public string InputFileURL { get; set; }

        /// <summary>
        /// <para>The maximum number of media workflow execution instances to return. Valid values: <c>[1,100]</c>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaximumPageSize")]
        [Validation(Required=false)]
        public long? MaximumPageSize { get; set; }

        /// <summary>
        /// <para>The ID of the media workflow whose execution instances you want to query. To obtain the workflow ID, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Workflows</b> &gt; <b>Workflow Settings</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43b7335a4b1d4fe883670036affb****</para>
        /// </summary>
        [NameInMap("MediaWorkflowId")]
        [Validation(Required=false)]
        public string MediaWorkflowId { get; set; }

        /// <summary>
        /// <para>The name of the media workflow. To obtain the workflow name, you can log on to the <b>MPS console</b> and choose <b>Workflows</b> &gt; <b>Workflow Settings</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-mediaworkflow-****</para>
        /// </summary>
        [NameInMap("MediaWorkflowName")]
        [Validation(Required=false)]
        public string MediaWorkflowName { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. The value is a UUID that contains 32 characters. When you request the first page of query results, leave the NextPageToken parameter empty. When you request more query results, specify the value of the NextPageToken parameter returned in the query results on the previous page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
