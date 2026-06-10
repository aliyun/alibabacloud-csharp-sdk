// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateFuncSwitchRecordShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Diagnosis channel (currently fixed to the ecs channel)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>Diagnosis parameters. Different diagnosis types require different diagnosis parameters. You can use this field to filter records whose parameters match specified values.</para>
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
