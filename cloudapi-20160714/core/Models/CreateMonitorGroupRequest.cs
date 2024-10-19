// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateMonitorGroupRequest : TeaModel {
        /// <summary>
        /// <para>The caller authentication status of the API. Valid values: <b>ok</b>: The authentication is successful. <b>mismatch</b>: The request is redirected. <b>servicenotfound</b>: A request error occurred. <b>Unknown</b>: An unknown error occurred.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Auth")]
        [Validation(Required=false)]
        public string Auth { get; set; }

        /// <summary>
        /// <para>The ID of the API group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6735211ab9094c818f32f27bc545b6c8</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the monitoring group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>166636221</para>
        /// </summary>
        [NameInMap("RawMonitorGroupId")]
        [Validation(Required=false)]
        public long? RawMonitorGroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
