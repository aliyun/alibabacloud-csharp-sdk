// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetServiceFuncStatusShrinkRequest : TeaModel {
        /// <summary>
        /// <para>channel name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>Diagnosis parameters. Different types of diagnosis require different diagnosis parameters. You can use this field to filter records whose parameter values match the specified values.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string ParamsShrink { get; set; }

        /// <summary>
        /// <para>Service Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>livetrace</para>
        /// </summary>
        [NameInMap("service_name")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
