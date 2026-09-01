// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAccountsInResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>La liste des comptes membres dans le répertoire de ressources.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<ListAccountsInResourceDirectoryResponseBodyAccounts> Accounts { get; set; }
        public class ListAccountsInResourceDirectoryResponseBodyAccounts : TeaModel {
            /// <summary>
            /// <para>L\&quot;identifiant de compte Alibaba Cloud du membre.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180803538814****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Ce paramètre est obsolète et ne doit plus être utilisé.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true.</para>
            /// </summary>
            [NameInMap("BuySas")]
            [Validation(Required=false)]
            [Obsolete]
            public int? BuySas { get; set; }

            /// <summary>
            /// <para>Indique si une instance Security Center en abonnement a été souscrite. Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true.</para>
            /// </summary>
            [NameInMap("BuySasNew")]
            [Validation(Required=false)]
            public bool? BuySasNew { get; set; }

            /// <summary>
            /// <para>Le mode de facturation de l\&quot;abonnement. Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> : prépayé</description></item>
            /// <item><description><b>1</b> : paiement à l\&quot;usage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public int? ChargeType { get; set; }

            /// <summary>
            /// <para>Le nom du compte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc**</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>L\&quot;identifiant du dossier dans le répertoire de ressources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-cE2SQP****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>Le type d\&quot;achat de l\&quot;instance. Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> : achat direct</description></item>
            /// <item><description><b>1</b> : alloué via la gestion multi-comptes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstanceBuyType")]
            [Validation(Required=false)]
            public int? InstanceBuyType { get; set; }

            /// <summary>
            /// <para>Indique si le compte est le compte de gestion du répertoire de ressources. Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description><para><b>yes</b></para>
            /// </description></item>
            /// <item><description><para><b>no</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsMaAccount")]
            [Validation(Required=false)]
            public string IsMaAccount { get; set; }

            /// <summary>
            /// <para>Indique si le compte est marqué comme suivi.</para>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsMarked")]
            [Validation(Required=false)]
            public string IsMarked { get; set; }

            /// <summary>
            /// <para>Indique si le compte est un compte administrateur délégué de Security Center. Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description><para><b>yes</b></para>
            /// </description></item>
            /// <item><description><para><b>no</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsSasDaAccount")]
            [Validation(Required=false)]
            public string IsSasDaAccount { get; set; }

            /// <summary>
            /// <para>Indique si le compte est un compte de gestion de Cloud Threat Detection and Response (CTDR). Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description><para><b>yes</b></para>
            /// </description></item>
            /// <item><description><para><b>no</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsSiemControlAccount")]
            [Validation(Required=false)]
            public string IsSiemControlAccount { get; set; }

            /// <summary>
            /// <para>Indique si le compte est un compte administrateur délégué de Cloud Threat Detection and Response (CTDR). Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description><para><b>yes</b></para>
            /// </description></item>
            /// <item><description><para><b>no</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("IsSiemDaAccount")]
            [Validation(Required=false)]
            public string IsSiemDaAccount { get; set; }

            /// <summary>
            /// <para>Le commutateur de module à paiement à l\&quot;usage. Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> : désactivé</description></item>
            /// <item><description><b>1</b> : activé.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostBasicService")]
            [Validation(Required=false)]
            public int? PostBasicService { get; set; }

            /// <summary>
            /// <para>L\&quot;état des commutateurs de modules à paiement à l\&quot;usage, au format JsonString. Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description>Clé :<list type="bullet">
            /// <item><description><b>VUL</b> : module de gestion des vulnérabilités</description></item>
            /// <item><description><b>CSPM</b> : module Cloud Security Posture Management (CSPM)</description></item>
            /// <item><description><b>AGENTLESS</b> : module de détection sans agent</description></item>
            /// <item><description><b>SERVERLESS</b> : module de ressources serverless</description></item>
            /// <item><description><b>CTDR</b> : module Cloud Threat Detection and Response (CTDR)</description></item>
            /// <item><description><b>RASP</b> : module Runtime Application Self-Protection (RASP)</description></item>
            /// <item><description><b>SDK</b> : module SDK de détection de fichiers malveillants</description></item>
            /// <item><description><b>POST_HOST</b> : module de sécurité des hôtes et des conteneurs</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Valeur : 0 indique désactivé. 1 indique activé.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;VUL\&quot;:0}</para>
            /// </summary>
            [NameInMap("PostPayModuleSwitch")]
            [Validation(Required=false)]
            public string PostPayModuleSwitch { get; set; }

            /// <summary>
            /// <para>L\&quot;identifiant de l\&quot;instance Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postpay-sas-x5x3hy1ly***</para>
            /// </summary>
            [NameInMap("SaleInstance")]
            [Validation(Required=false)]
            public string SaleInstance { get; set; }

            /// <summary>
            /// <para>L\&quot;édition souscrite de Security Center. Valeurs valides :</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> ou <b>1</b> : Édition gratuite</description></item>
            /// <item><description><b>2</b> ou <b>3</b> : Édition Enterprise  </description></item>
            /// <item><description><b>5</b> : Édition Premium  </description></item>
            /// <item><description><b>6</b> : Édition Anti-virus </description></item>
            /// <item><description><b>7</b> : Édition Ultimate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SasVersion")]
            [Validation(Required=false)]
            public string SasVersion { get; set; }

        }

        /// <summary>
        /// <para>L\&quot;identifiant de la requête. Il s\&quot;agit d\&quot;un identifiant unique généré par Alibaba Cloud pour la requête. Vous pouvez l\&quot;utiliser pour le dépannage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7A839E8-70AE-591D-8D9E-C5419A2240DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
