// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListOncallSchedulesShrinkRequest : TeaModel {
        [NameInMap("oncallScheduleIds")]
        [Validation(Required=false)]
        public string OncallScheduleIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testOncallScheduleName</para>
        /// </summary>
        [NameInMap("oncallScheduleName")]
        [Validation(Required=false)]
        public string OncallScheduleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default-cms-5884500827389836-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
