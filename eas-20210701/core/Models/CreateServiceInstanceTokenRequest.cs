// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceInstanceTokenRequest : TeaModel {
        /// <summary>
        /// <para>Type of URL to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WorkBench</b>: Log on to the container using Workbench.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WorkBench</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>Name of the service worker. Call the ListServiceContainers operation to get the worker name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker0</para>
        /// </summary>
        [NameInMap("WorkerName")]
        [Validation(Required=false)]
        public string WorkerName { get; set; }

    }

}
