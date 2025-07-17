// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteRumAppRequest : TeaModel {
        /// <summary>
        /// <para>The group where the application resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("AppGroup")]
        [Validation(Required=false)]
        public string AppGroup { get; set; }

        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b590lhguqs@28f515462******</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The region where the application resides. You can leave this parameter empty or set it to China East 2 Finance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-finance-1</para>
        /// </summary>
        [NameInMap("RealRegionId")]
        [Validation(Required=false)]
        public string RealRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
