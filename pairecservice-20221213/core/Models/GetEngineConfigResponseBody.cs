// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetEngineConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the engine configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The description of the engine configuration.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Daily: The daily environment.</para>
        /// </description></item>
        /// <item><description><para>Pre: The pre-production environment.</para>
        /// </description></item>
        /// <item><description><para>Prod: The production environment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pre</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The time the engine configuration was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-03T02:28:00.000Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time the engine configuration was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-27T12:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The time the engine configuration was published.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-03 02:28:00</para>
        /// </summary>
        [NameInMap("GmtReleasedTime")]
        [Validation(Required=false)]
        public string GmtReleasedTime { get; set; }

        /// <summary>
        /// <para>The engine configuration name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>engine_config_v1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59CE7EC6-F268-5D71-9215-32922CC50D72</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Released: Published</para>
        /// </description></item>
        /// <item><description><para>UnReleased: Unpublished</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Released</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
