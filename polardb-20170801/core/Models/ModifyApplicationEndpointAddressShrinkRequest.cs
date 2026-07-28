// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyApplicationEndpointAddressShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The network type of the endpoint address. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Public</b>: public network.</description></item>
        /// <item><description><b>Private</b>: private network.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <summary>
        /// <para>The new endpoint prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xg06iror0l</para>
        /// </summary>
        [NameInMap("NewConnectionStringPrefix")]
        [Validation(Required=false)]
        public string NewConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The list of new ports.</para>
        /// </summary>
        [NameInMap("NewPorts")]
        [Validation(Required=false)]
        public string NewPortsShrink { get; set; }

    }

}
