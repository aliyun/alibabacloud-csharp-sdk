// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTagResourcesForExpressConnectResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value can be used in the next request to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tags that are added to the resource.</para>
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public ListTagResourcesForExpressConnectResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesForExpressConnectResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<ListTagResourcesForExpressConnectResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesForExpressConnectResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-bp16qjewdsunr41m1****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The type of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PHYSICALCONNECTION</b>: Express Connect circuit.</description></item>
                /// <item><description><b>VIRTUALBORDERROUTER</b>: VBR.</description></item>
                /// <item><description><b>ROUTERINTERFACE</b>: router interface.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PHYSICALCONNECTION</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The key of the tag that is added to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag that is added to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
