// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshVodObjectCachesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to purge resources in a directory if the resources requested are different from the resources on the origin server.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: refreshes all resources in the directory. If you set this parameter to true, when the requested content matches the resource in the directory, the POP retrieves the resource from the origin server, returns the resource to the client, and caches the resource.</description></item>
        /// <item><description><b>false</b> (default): refreshes the changed resources in the directory. If you set this parameter to false, when the requested content matches the resource in the directory, the POP obtains the Last-Modified parameter of the resource from the origin server. If the value of the obtained Last-Modified parameter is the same as that of the cached resource, the cached resource is returned. Otherwise, the POP retrieves the resource from the origin server, returns the resource to the client, and caches the resource.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The URL of the file to be prefetched. Separate multiple URLs with line breaks (\n or \r\n).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc.com/image/1.png</para>
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// <para>The type of the object that you want to refresh. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>File</b> (default): refreshes one or more files.</description></item>
        /// <item><description><b>Directory</b>: refreshes the files in specified directories.</description></item>
        /// <item><description><b>Regex</b>: refreshes content based on regular expressions.</description></item>
        /// <item><description><b>IgnoreParams</b>: removes the question mark (?) and parameters after the question mark (?) in a request URL and refreshes content. After you call this operation with the request URL submitted, the system compares the submitted URL with the URL of the cached resource without specific parameters. If the URLs match, the POPs refresh the cached resource.</description></item>
        /// </list>
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
