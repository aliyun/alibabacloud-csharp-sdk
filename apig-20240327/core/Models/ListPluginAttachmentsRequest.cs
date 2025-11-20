// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginAttachmentsRequest : TeaModel {
        /// <summary>
        /// <para>The resource attachment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr-cv2h58em1hkg7c6vt43g</para>
        /// </summary>
        [NameInMap("attachResourceId")]
        [Validation(Required=false)]
        public string AttachResourceId { get; set; }

        /// <summary>
        /// <para>The resource attachment type (not yet in use).</para>
        /// 
        /// <b>Example:</b>
        /// <para>GatewayRoute</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The resource attachment types, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GatewayRoute</para>
        /// </summary>
        [NameInMap("attachResourceTypes")]
        [Validation(Required=false)]
        public string AttachResourceTypes { get; set; }

        /// <summary>
        /// <para>The environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-crlnqhtlhtgqflkqislg</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cr79f75lhtgme744084g</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The page number to return. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The plug-in ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-ct8181um1hkiqns9f6e0</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return parent resource attachments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withParentResource")]
        [Validation(Required=false)]
        public bool? WithParentResource { get; set; }

    }

}
