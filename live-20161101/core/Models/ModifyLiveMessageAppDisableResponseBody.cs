// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveMessageAppDisableResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab6b5740****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The signature of the interactive messaging application. It is required by the interactive messaging SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>H4sIAAAAAAAE/wBwAI//zguHB+lYCilkv7diSkk4GhHQAvMXs5tWyI+I09+uEBiB5sqa28ycJSJFmsd50Mhz8nDrvvqmti+fVaNLC5CMgLvNIy48v1aV9x74LRNFN0+Dxd2Al51xuDNkEIDaEwjqfyxscTXjSr0iQjHu2WgkpQAAAP//AQAA//+yR5XCc****</para>
        /// </summary>
        [NameInMap("AppSign")]
        [Validation(Required=false)]
        public string AppSign { get; set; }

        /// <summary>
        /// <para>Indicates whether the interactive messaging application is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Disable")]
        [Validation(Required=false)]
        public bool? Disable { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6AA1AE11-EA78-1FD4-A966-6BA843073F6D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
