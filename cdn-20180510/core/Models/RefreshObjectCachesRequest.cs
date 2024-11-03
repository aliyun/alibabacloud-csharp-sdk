// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class RefreshObjectCachesRequest : TeaModel {
        /// <summary>
        /// <para>When the comparison between the source content and the source site resources is consistent, should the resources within the corresponding range be forcibly refreshed. The default is false.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: purges all resources in the range that corresponds to the type of the purge task. If you set this parameter to true, when the requested resource matches the resource in the range that corresponds to the type of the purge task, the POP retrieves the resource from the origin server, returns the resource to the client, and caches the resource.</description></item>
        /// <item><description><b>false</b>: purges the changed resources in the range that corresponds to the type of the purge task. If you set this parameter to false, when the requested resource matches the resource in the range that corresponds to the type of the purge task, the POP obtains the Last-Modified parameter of the resource from the origin server. If the obtained value of the Last-Modified parameter is the same as that of the cached resource, the cached resource is returned. Otherwise, the POP retrieves the resource from the origin server, returns the resource to the client, and caches the resource.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only when the ObjectType parameter is not set to File.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If you submit multiple URLs or directories at a time, separate them with line breaks (\n) or (\r\n).</description></item>
        /// <item><description>The total number of domain names contained all URLs in a submitted task cannot exceed 10.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/image/1.png%5C%5Cnhttp://aliyundoc.com/image/2.png">http://example.com/image/1.png\\nhttp://aliyundoc.com/image/2.png</a></para>
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// <para>The type of the object that you want to refresh. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>File</b> (default): refreshes one or more files.</description></item>
        /// <item><description><b>Directory</b>: refreshes the files in one or more directories.</description></item>
        /// <item><description><b>Regex</b>: refreshes content based on regular expressions.</description></item>
        /// <item><description><b>ExQuery</b>: omits parameters after the question mark in the URL and refreshes content.</description></item>
        /// </list>
        /// <para>If you set the ObjectType parameter to File or Directory, you can view <a href="https://help.aliyun.com/document_detail/27140.html">Refresh and prefetch resources</a> to obtain more information. If you set the ObjectType parameter to Regex, you can view <a href="https://help.aliyun.com/document_detail/146195.html">Configure URL refresh rules that contain regular expressions</a> to obtain more information.</para>
        /// <para>If you set the ObjectType parameter to Directory, the resources in the directory that you want to refresh are marked as expired. You cannot delete the directory. If clients request resources on POPs that are marked as expired, Alibaba Cloud CDN checks whether the resources on your origin server are updated. If resources are updated, Alibaba Cloud CDN retrieves the latest version of the resources and returns the resources to the clients. Otherwise, the origin server returns the 304 status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
