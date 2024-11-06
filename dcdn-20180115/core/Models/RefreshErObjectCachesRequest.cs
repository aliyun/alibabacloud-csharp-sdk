// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class RefreshErObjectCachesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to refresh resources in a directory if the resources requested are different from the resources on the origin server. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: refreshes all resources in the directory.</description></item>
        /// <item><description><b>false</b>: refreshes the changed resources in the directory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The domain names that are merged for refreshing. POPs that provide services for the domain names are refreshed.</para>
        /// <remarks>
        /// <para> Separate multiple domain names with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a.test.com,b.test.com</para>
        /// </summary>
        [NameInMap("MergeDomainName")]
        [Validation(Required=false)]
        public string MergeDomainName { get; set; }

        /// <summary>
        /// <para>The URL that you want to refresh.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Separate URLs with line feeds (\n or \r\n). Each object path can be up to 1,024 characters in length.</description></item>
        /// <item><description>The URLs in a request must belong to the same domain name.</description></item>
        /// <item><description>You can refresh up to 1,000 URLs in each request.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/examplefile.txt">http://example.com/examplefile.txt</a></para>
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// <para>The refresh type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>File</b> (default): refreshes content based on URLs.</description></item>
        /// <item><description><b>Directory</b>: refreshes content based on directories.</description></item>
        /// <item><description><b>Regex</b>: refreshes content based on regular expressions.</description></item>
        /// <item><description><b>IgnoreParams</b>: removes the question mark (<c>?</c>) and parameters after the question mark (<c>?</c>) in a request URL and refreshes content. After you call this operation with the request URL submitted, the system compares the submitted URL with the URL of the cached resource without specific parameters. If the URLs match, the points of presence (POPs) refresh the cached resource.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you refresh the files in one or more directories, the resources in the directory that you want to refresh are marked as expired. You cannot delete the directory. If clients request resources on POPs that are marked as expired, Dynamic Content Delivery Network (DCDN) checks whether the resources on your origin server are updated. If resources are updated, DCDN retrieves the latest version of the resources and returns the resources to the clients. Otherwise, the origin server returns the 304 status code.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The ID of the routine, which is in the format of &quot;Name.Subdomain&quot; and is the unique identifier of a custom routine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.mysubdomain</para>
        /// </summary>
        [NameInMap("RoutineId")]
        [Validation(Required=false)]
        public string RoutineId { get; set; }

    }

}
