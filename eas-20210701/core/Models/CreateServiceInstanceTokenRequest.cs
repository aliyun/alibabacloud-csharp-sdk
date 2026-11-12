// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceInstanceTokenRequest : TeaModel {
        /// <summary>
        /// <para>The type of URL to retrieve. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WorkBench</b>: Logs on to the container through the Workbench page.</description></item>
        /// <item><description><b>WebShell</b>: Logs on to the container through a WebSocket URL. This value is not supported for processor-type services or services created before June 2026.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WorkBench</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>The name of the service worker. You can call the ListServiceContainers operation to obtain the worker name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker0</para>
        /// </summary>
        [NameInMap("WorkerName")]
        [Validation(Required=false)]
        public string WorkerName { get; set; }

    }

}
